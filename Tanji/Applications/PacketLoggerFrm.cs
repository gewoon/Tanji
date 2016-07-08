﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Tanji.Components;
using Tanji.Manipulators;
using Tanji.Applications.Dialogs;

using Sulakore.Protocol;
using Sulakore.Communication;

using Tangine.Classes;

using FlashInspect.ActionScript;
using System.Diagnostics;
using System.Linq;

namespace Tanji.Applications
{
    public partial class PacketLoggerFrm : TanjiForm, IReceiver, IHaltable
    {
        private Task _readQueueTask;
        private FindDialog _currentFindUI;
        private FindMessageDialog _currentFindMessageUI;
        private IgnoreMessagesDialog _currentIgnoreMessagesUI;

        private readonly object _pushToQueueLock;
        private readonly Action<string, Color> _writeHighlight;
        private readonly List<ushort> _invalidParsers, _invalidStructures;
        private readonly Dictionary<ushort, bool> _ignoredOutgoing, _ignoredIncoming;

        public MainFrm MainUI { get; }
        public Queue<DataInterceptedEventArgs> Intercepted { get; }

        public Color SpecialHighlight { get; set; } = Color.DarkGray;
        public Color IncomingHighlight { get; set; } = Color.FromArgb(178, 34, 34);
        public Color OutgoingHighlight { get; set; } = Color.FromArgb(0, 102, 204);
        public Color StructureHighlight { get; set; } = Color.FromArgb(0, 204, 136);

        public bool IsFindDialogOpened
        {
            get
            {
                return (_currentFindUI != null &&
                    !_currentFindUI.IsDisposed);
            }
        }
        public bool IsFindMessageDialogOpened
        {
            get
            {
                return (_currentFindMessageUI != null &&
                    !_currentFindMessageUI.IsDisposed);
            }
        }
        public bool IsIgnoreMessagesDialogOpened
        {
            get
            {
                return (_currentIgnoreMessagesUI != null &&
                    !_currentIgnoreMessagesUI.IsDisposed);
            }
        }

        public bool IsReceiving { get; private set; } = true;
        public bool IsViewingOutgoing { get; private set; } = true;
        public bool IsViewingIncoming { get; private set; } = true;

        public bool IsDisplayingHash { get; private set; }
        public bool IsDisplayingTimestamp { get; private set; }
        public bool IsDisplayingBlocked { get; private set; } = true;
        public bool IsDisplayingReplaced { get; private set; } = true;
        public bool IsDisplayingStructure { get; private set; } = true;
        public bool IsDisplayingParserName { get; private set; } = true;
        public bool IsDisplayingMessageName { get; private set; } = true;

        public PacketLoggerFrm(MainFrm mainUI)
        {
            InitializeComponent();

            _writeHighlight = WriteHighlight;

            _pushToQueueLock = new object();
            _invalidParsers = new List<ushort>();
            _invalidStructures = new List<ushort>();
            _ignoredOutgoing = new Dictionary<ushort, bool>();
            _ignoredIncoming = new Dictionary<ushort, bool>();

            MainUI = mainUI;
            Intercepted = new Queue<DataInterceptedEventArgs>();
        }

        private void Item_Checked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            bool isChecked = item.Checked;

            switch (item.Name)
            {
                case nameof(ViewIncomingBtn):
                {
                    ViewIncomingLbl.Text = ("Viewing Incoming: " + isChecked);
                    IsViewingIncoming = isChecked;
                    break;
                }
                case nameof(ViewOutgoingBtn):
                {
                    ViewOutgoingLbl.Text = ("Viewing Outgoing: " + isChecked);
                    IsViewingOutgoing = isChecked;
                    break;
                }
                case nameof(DisplayStructureBtn):
                {
                    IsDisplayingStructure = isChecked;
                    break;
                }
                case nameof(BlockedBtn):
                {
                    IsDisplayingBlocked = isChecked;
                    break;
                }
                case nameof(ReplacedBtn):
                {
                    IsDisplayingReplaced = isChecked;
                    break;
                }
                case nameof(HashBtn):
                {
                    IsDisplayingHash = isChecked;
                    break;
                }
                case nameof(TimestampBtn):
                {
                    IsDisplayingTimestamp = isChecked;
                    break;
                }
                case nameof(ClassNameBtn):
                {
                    IsDisplayingMessageName = isChecked;
                    break;
                }
                case nameof(ParserName):
                {
                    IsDisplayingParserName = isChecked;
                    break;
                }
                case nameof(AlwaysOnTopBtn):
                {
                    TopMost = isChecked;
                    MainUI.TopMost = isChecked;
                    break;
                }
            }
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggerTxt.SelectedText))
                Clipboard.SetText(LoggerTxt.SelectedText);
        }
        private void EmptyLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (IsFindDialogOpened)
            {
                _currentFindUI.BringToFront();
            }
            else
            {
                _currentFindUI = new FindDialog(LoggerTxt);
                _currentFindUI.Show(this);
            }
            _currentFindUI.FindWhat = LoggerTxt.SelectedText;
            _currentFindUI.FindWhatTxt.SelectAll();
        }
        private void FindMessageBtn_Click(object sender, EventArgs e)
        {
            if (IsFindMessageDialogOpened)
            {
                _currentFindMessageUI.BringToFront();
            }
            else
            {
                _currentFindMessageUI = new FindMessageDialog(MainUI.Game);
                _currentFindMessageUI.Show(this);
            }
            _currentFindMessageUI.Hash = LoggerTxt.SelectedText;
            _currentFindMessageUI.HashTxt.SelectAll();
        }
        private void IgnoreMessagesBtn_Click(object sender, EventArgs e)
        {
            if (IsIgnoreMessagesDialogOpened)
            {
                _currentIgnoreMessagesUI.BringToFront();
            }
            else
            {
                _currentIgnoreMessagesUI = new IgnoreMessagesDialog(
                    _ignoredOutgoing, _ignoredIncoming);

                _currentIgnoreMessagesUI.Show(this);
            }
        }

        public void Halt()
        {
            Close();
            Hide();
        }
        public void HandleOutgoing(DataInterceptedEventArgs e) => PushToQueue(e);
        public void HandleIncoming(DataInterceptedEventArgs e) => PushToQueue(e);

        public void WriteHighlight(string value, Color highlight)
        {
            if (InvokeRequired) Invoke(_writeHighlight, value, highlight);
            else
            {
                LoggerTxt.SelectionStart = LoggerTxt.TextLength;
                LoggerTxt.SelectionLength = 0;
                LoggerTxt.SelectionColor = highlight;
                LoggerTxt.AppendText(value);
            }
        }
        public void WritePacketLog(DataInterceptedEventArgs args)
        {
            HMessage packet = args.Packet;
            bool isOutgoing = (args.Packet.Destination == HDestination.Server);

            ReadOnlyDictionary<ushort, ASClass> msgClasses = (isOutgoing ?
                MainUI.Game.OutgoingMessages : MainUI.Game.IncomingMessages);

            ASClass msgClass = null;
            msgClasses.TryGetValue(packet.Header, out msgClass);

            Color highlight = (isOutgoing ?
                OutgoingHighlight : IncomingHighlight);

            if (IsDisplayingTimestamp)
                WriteHighlight($"[{DateTime.Now.ToLongTimeString()}]\r\n", SpecialHighlight);

            if (IsDisplayingHash)
            {
                string hash = MainUI.Game.GetMessageHash(msgClass);
                WriteHighlight($"[{hash}]\r\n", SpecialHighlight);
            }

            WriteHighlight((isOutgoing ?
                "Outgoing" : "Incoming"), highlight);

            if (args.IsBlocked && IsDisplayingBlocked)
            {
                WriteHighlight("[Blocked]", SpecialHighlight);
            }
            else if (!args.IsOriginal)
            {
                WriteHighlight("[Replaced]", SpecialHighlight);
            }

            string arrow = (isOutgoing ? "->" : "<-");
            WriteHighlight($"({packet.Header}, {packet.Length}", highlight);

            if (IsDisplayingMessageName && msgClass != null)
            {
                WriteHighlight(", ", highlight);
                WriteHighlight((msgClass?.Instance.QualifiedName.Name) ?? "???", SpecialHighlight);
            }
            if (!isOutgoing && IsDisplayingParserName &&
                msgClass != null && !_invalidParsers.Contains(packet.Header))
            {
                ASClass parserClass = MainUI.Game
                    .GetIncomingMessageParser(msgClass);

                if (parserClass != null)
                {
                    WriteHighlight($", ", highlight);
                    WriteHighlight(parserClass.Instance.QualifiedName.Name, SpecialHighlight);
                }
                else _invalidParsers.Add(packet.Header);
            }
            WriteHighlight($") {arrow} {packet}\r\n", highlight);

            if (IsDisplayingStructure && isOutgoing)
                WriteStructureLog(packet, msgClass);
        }
        public void WriteStructureLog(HMessage packet, ASClass messageClass)
        {
            if (_invalidStructures.Contains(packet.Header))
                return;

            int position = 0;
            string structureLog = $"{{l}}{{u:{packet.Header}}}";
            ASMethod msgCtor = messageClass.Instance.Constructor;
            foreach (ASParameter parameter in msgCtor.Parameters)
            {
                switch (parameter.Type.Name.ToLower())
                {
                    case "string":
                    if (!packet.IsStringReadable(position)) continue;
                    structureLog += ($"{{s:{packet.ReadString(ref position)}}}");
                    break;

                    case "boolean":
                    if (packet.GetReadableBytes(position) < 1) continue;
                    structureLog += ($"{{b:{packet.ReadBoolean(ref position)}}}");
                    break;

                    case "int":
                    if (packet.GetReadableBytes(position) < 4) continue;
                    structureLog += ($"{{i:{packet.ReadInteger(ref position)}}}");
                    break;
                }
            }
            if (packet.GetReadableBytes(position) == 0)
            {
                WriteHighlight(structureLog + "\r\n", StructureHighlight);
            }
            else _invalidStructures.Add(packet.Header);
        }

        private void LogMessageQueue()
        {
            if (Intercepted.Count > 0 &&
                (_readQueueTask?.IsCompleted ?? true))
            {
                _readQueueTask = Task.Factory
                    .StartNew(MessageQueueLogger);
            }
        }
        private void MessageQueueLogger()
        {
            bool wasLockTaken = false;
            try
            {
                Monitor.TryEnter(Intercepted, ref wasLockTaken);
                if (!wasLockTaken) return;

                while (Intercepted.Count > 0)
                {
                    DataInterceptedEventArgs args = Intercepted.Dequeue();
                    if (!IsLoggingAuthorized(args)) continue;

                    WritePacketLog(args);
                    WriteHighlight("--------------------\r\n", SpecialHighlight);
                }
            }
            finally
            {
                if (wasLockTaken)
                {
                    Monitor.Exit(Intercepted);
                    Application.DoEvents();
                }
            }
        }
        private void PushToQueue(DataInterceptedEventArgs e)
        {
            lock (_pushToQueueLock)
            {
                if (IsLoggingAuthorized(e))
                {
                    Intercepted.Enqueue(e);
                    LogMessageQueue();
                }
            }
        }

        private bool IsLoggingAuthorized(DataInterceptedEventArgs e)
        {
            bool isOutgoing =
                (e.Packet.Destination == HDestination.Server);

            if (IsFindDialogOpened) return false;
            if (IsFindMessageDialogOpened) return false;

            if (!IsDisplayingBlocked && e.IsBlocked) return false;
            if (!IsDisplayingReplaced && !e.IsOriginal) return false;

            ushort header = e.Packet.Header;
            if (isOutgoing)
            {
                if (!IsViewingOutgoing ||
                    IsIgnoring(header, _ignoredOutgoing))
                {
                    return false;
                }
            }
            else
            {
                if (!IsViewingIncoming ||
                    IsIgnoring(header, _ignoredIncoming))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsIgnoring(ushort header, IDictionary<ushort, bool> ignored)
        {
            bool isIgnoring = false;
            ignored.TryGetValue(header, out isIgnoring);
            return isIgnoring;
        }

        private void PacketLoggerFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (string.IsNullOrEmpty(LoggerTxt.SelectedText)) return;

                var menu = new ContextMenu();
                menu.MenuItems.Add("Copy", CopyBtn_Click);

                LoggerEntry data = new LoggerEntry();
                data.Input = LoggerTxt.SelectedText;

                if (data.isValid())
                {
                    data = new LoggerEntry(data.Input);
                    var packet = data.Args.Packet;

                    if (!data.isStructureEntry && !packet.IsCorrupted)
                        menu.MenuItems.Add("Send again", new EventHandler((o, ea) => ReSend(packet)));

                    menu.MenuItems.Add("-");

                    var item = new MenuItem("Export to..");
                    menu.MenuItems.Add(item);

                    if (data.isStructureEntry)
                    {
                        item.MenuItems.Add("Constructer", new EventHandler((o, ea) => ToConstructor(LoggerTxt.SelectedText)));
                        item.MenuItems.Add("-");
                    }

                    item.MenuItems.Add("Primitive", new EventHandler((o, ea) => ToPrimitive(packet.ToString())));
                    item.MenuItems.Add("Scheduler", new EventHandler((o, ea) => ToScheduler(packet)));
                    item.MenuItems.Add("Filters", new EventHandler((o, ea) => ToFilters(packet)));
                }
                LoggerTxt.ContextMenu = menu;
            }
        }

        private void ToConstructor(string data)
        {
            MainUI.BringToFront();
            MainUI.Activate();

            MainUI.TanjiTabs.SelectTab(1);
            MainUI.InjectionTabs.SelectTab(0);

            MainUI.CTClearBtn.PerformClick();

            List<string> splitted = data.Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 1; i < splitted.Count; i++)
            {
                string[] splittedd = splitted[i].Split(new[] { ':' }, 2, StringSplitOptions.None);

                switch (splittedd[0])
                {
                    case "u":
                        MainUI.CTHeaderTxt.Value = int.Parse(splittedd[1]);
                        break;
                    case "s":
                        MainUI.InjectionPg.ConstructerPg.WriteString(splittedd[1]);
                        break;
                    case "i":
                        MainUI.InjectionPg.ConstructerPg.WriteInteger(int.Parse(splittedd[1]));
                        break;
                    case "b":
                        MainUI.InjectionPg.ConstructerPg.WriteBoolean(Boolean.Parse(splittedd[1]));
                        break;
                    default:
                        break;
                }
            }
        }
        private void ToScheduler(HMessage packet)
        {
            MainUI.BringToFront();
            MainUI.Activate();

            MainUI.TanjiTabs.SelectTab(1);
            MainUI.InjectionTabs.SelectTab(1);

            MainUI.STPacketTxt.Text = packet.ToString();
            MainUI.STDestinationTxt.SelectedIndex = (packet.Destination == HDestination.Server) ? 1 : 0;
        }
        private void ToPrimitive(string packet)
        {
            MainUI.BringToFront();
            MainUI.Activate();

            MainUI.TanjiTabs.SelectTab(1);
            MainUI.InjectionTabs.SelectTab(2);

            MainUI.PTPacketTxt.Text = packet;
        }
        private void ToFilters(HMessage packet)
        {
            MainUI.BringToFront();
            MainUI.Activate();

            MainUI.TanjiTabs.SelectTab(1);
            MainUI.InjectionTabs.SelectTab(3);

            MainUI.FTHeaderTxt.Value = packet.Header;
            MainUI.FTDestinationTxt.SelectedIndex = (packet.Destination == HDestination.Server) ? 1 : 0;
        }

        private async void ReSend(HMessage packet)
        {
            if (packet.Destination == HDestination.Server)
                await MainUI.Connection.SendToServerAsync(packet.ToBytes());
            else
                await MainUI.Connection.SendToClientAsync(packet.ToBytes());
        }

        protected override void OnActivated(EventArgs e)
        {
            if (!IsReceiving)
            {
                LoggerTxt.Clear();
                IsReceiving = true;
            }
            LogMessageQueue();
            base.OnActivated(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            IsReceiving = false;

            e.Cancel = true;
            Intercepted.Clear();

            LoggerTxt.Clear();
            WindowState = FormWindowState.Minimized;

            base.OnFormClosing(e);
        }
    }
}