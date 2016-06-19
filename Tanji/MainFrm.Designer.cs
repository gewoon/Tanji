namespace Tanji
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TanjiStrip = new System.Windows.Forms.StatusStrip();
            this.TanjiVersionTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.FiltersTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.InstallModuleDlg = new System.Windows.Forms.OpenFileDialog();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.ConnectionTab = new System.Windows.Forms.TabPage();
            this.ConnectionPg = new Tanji.Components.Pages.ConnectionPage();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.ITSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ITSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.ConstructerPg = new Tanji.Components.Pages.ConstructerPage();
            this.SchedulerTab = new System.Windows.Forms.TabPage();
            this.SchedulerPg = new Tanji.Components.Pages.SchedulerPage();
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PrimitivePg = new Tanji.Components.Pages.PrimitivePage();
            this.FiltersTab = new System.Windows.Forms.TabPage();
            this.FiltersPg = new Tanji.Components.Pages.FiltersPage();
            this.ITPacketTxt = new System.Windows.Forms.ComboBox();
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.ToolboxPg = new Tanji.Components.Pages.ToolboxPage();
            this.ModulesTab = new System.Windows.Forms.TabPage();
            this.ModulesPg = new Tanji.Components.Pages.ModulesPage();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.OptionsPg = new Tanji.Components.Pages.OptionsPage();
            this.InjectionMenu = new Sulakore.Components.SKoreInjectionMenu(this.components);
            this.SavePacketDlg = new System.Windows.Forms.SaveFileDialog();
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            this.SchedulerTab.SuspendLayout();
            this.PrimitiveTab.SuspendLayout();
            this.FiltersTab.SuspendLayout();
            this.ToolboxTab.SuspendLayout();
            this.ModulesTab.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
            this.FiltersTxt,
            this.SchedulesTxt,
            this.ModulesTxt,
            this.TanjiInfoTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(484, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 5;
            // 
            // TanjiVersionTxt
            // 
            this.TanjiVersionTxt.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.TanjiVersionTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TanjiVersionTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TanjiVersionTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiVersionTxt.Name = "TanjiVersionTxt";
            this.TanjiVersionTxt.Size = new System.Drawing.Size(50, 19);
            this.TanjiVersionTxt.Text = "v0.0.0.0";
            this.TanjiVersionTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiVersionTxt.Click += new System.EventHandler(this.TanjiVersionTxt_Click);
            // 
            // FiltersTxt
            // 
            this.FiltersTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.FiltersTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FiltersTxt.Name = "FiltersTxt";
            this.FiltersTxt.Size = new System.Drawing.Size(65, 19);
            this.FiltersTxt.Text = "Filters: 0/0";
            // 
            // SchedulesTxt
            // 
            this.SchedulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SchedulesTxt.Name = "SchedulesTxt";
            this.SchedulesTxt.Size = new System.Drawing.Size(87, 19);
            this.SchedulesTxt.Text = "Schedules: 0/0";
            // 
            // ModulesTxt
            // 
            this.ModulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ModulesTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ModulesTxt.Name = "ModulesTxt";
            this.ModulesTxt.Size = new System.Drawing.Size(80, 19);
            this.ModulesTxt.Text = "Modules: 0/0";
            // 
            // TanjiInfoTxt
            // 
            this.TanjiInfoTxt.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.TanjiInfoTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TanjiInfoTxt.IsLink = true;
            this.TanjiInfoTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiInfoTxt.Name = "TanjiInfoTxt";
            this.TanjiInfoTxt.Size = new System.Drawing.Size(187, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub | ArachisH/Tanji";
            this.TanjiInfoTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // InstallModuleDlg
            // 
            this.InstallModuleDlg.DefaultExt = "dll";
            this.InstallModuleDlg.Filter = ".NET Assembly (*.dll, *.exe)|*.dll; *.exe|Dynamic Link Library (*.dll)|*.dll|Exec" +
    "utable (*.exe)|*.exe";
            this.InstallModuleDlg.Title = "Tanji ~ Install Module";
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.AllowDrop = true;
            this.TanjiTabs.Controls.Add(this.ConnectionTab);
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.ToolboxTab);
            this.TanjiTabs.Controls.Add(this.ModulesTab);
            this.TanjiTabs.Controls.Add(this.OptionsTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.ItemSize = new System.Drawing.Size(96, 24);
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(484, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiTabs.TabIndex = 6;
            // 
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.ConnectionPg);
            this.ConnectionTab.Location = new System.Drawing.Point(4, 28);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionTab.Size = new System.Drawing.Size(476, 313);
            this.ConnectionTab.TabIndex = 4;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.UseVisualStyleBackColor = true;
            // 
            // ConnectionPg
            // 
            this.ConnectionPg.BackColor = System.Drawing.Color.White;
            this.ConnectionPg.CustomClientPath = "";
            this.ConnectionPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionPg.IsReceiving = false;
            this.ConnectionPg.Location = new System.Drawing.Point(3, 3);
            this.ConnectionPg.Name = "ConnectionPg";
            this.ConnectionPg.Size = new System.Drawing.Size(470, 307);
            this.ConnectionPg.State = "Standing By";
            this.ConnectionPg.TabIndex = 0;
            // 
            // InjectionTab
            // 
            this.InjectionTab.Controls.Add(this.ITSendToClientBtn);
            this.InjectionTab.Controls.Add(this.ITSendToServerBtn);
            this.InjectionTab.Controls.Add(this.InjectionTabs);
            this.InjectionTab.Controls.Add(this.ITPacketTxt);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(476, 313);
            this.InjectionTab.TabIndex = 2;
            this.InjectionTab.Text = "Injection";
            this.InjectionTab.UseVisualStyleBackColor = true;
            // 
            // ITSendToClientBtn
            // 
            this.ITSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToClientBtn.Location = new System.Drawing.Point(266, 287);
            this.ITSendToClientBtn.Name = "ITSendToClientBtn";
            this.ITSendToClientBtn.Size = new System.Drawing.Size(99, 20);
            this.ITSendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ITSendToClientBtn.TabIndex = 7;
            this.ITSendToClientBtn.Text = "Send To Client";
            // 
            // ITSendToServerBtn
            // 
            this.ITSendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToServerBtn.Location = new System.Drawing.Point(371, 287);
            this.ITSendToServerBtn.Name = "ITSendToServerBtn";
            this.ITSendToServerBtn.Size = new System.Drawing.Size(99, 20);
            this.ITSendToServerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ITSendToServerBtn.TabIndex = 6;
            this.ITSendToServerBtn.Text = "Send To Server";
            // 
            // InjectionTabs
            // 
            this.InjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.InjectionTabs.Controls.Add(this.ConstructerTab);
            this.InjectionTabs.Controls.Add(this.SchedulerTab);
            this.InjectionTabs.Controls.Add(this.PrimitiveTab);
            this.InjectionTabs.Controls.Add(this.FiltersTab);
            this.InjectionTabs.DisplayBoundary = true;
            this.InjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.InjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.InjectionTabs.ItemSize = new System.Drawing.Size(24, 65);
            this.InjectionTabs.Location = new System.Drawing.Point(3, 3);
            this.InjectionTabs.Multiline = true;
            this.InjectionTabs.Name = "InjectionTabs";
            this.InjectionTabs.SelectedIndex = 0;
            this.InjectionTabs.Size = new System.Drawing.Size(470, 275);
            this.InjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.InjectionTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InjectionTabs.TabIndex = 0;
            // 
            // ConstructerTab
            // 
            this.ConstructerTab.Controls.Add(this.ConstructerPg);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConstructerTab.Size = new System.Drawing.Size(397, 267);
            this.ConstructerTab.TabIndex = 2;
            this.ConstructerTab.Text = "Constructer";
            this.ConstructerTab.UseVisualStyleBackColor = true;
            // 
            // ConstructerPg
            // 
            this.ConstructerPg.BackColor = System.Drawing.Color.White;
            this.ConstructerPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConstructerPg.Location = new System.Drawing.Point(3, 3);
            this.ConstructerPg.Name = "ConstructerPg";
            this.ConstructerPg.Size = new System.Drawing.Size(391, 261);
            this.ConstructerPg.TabIndex = 0;
            // 
            // SchedulerTab
            // 
            this.SchedulerTab.Controls.Add(this.SchedulerPg);
            this.SchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.SchedulerTab.Name = "SchedulerTab";
            this.SchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulerTab.Size = new System.Drawing.Size(397, 267);
            this.SchedulerTab.TabIndex = 0;
            this.SchedulerTab.Text = "Scheduler";
            this.SchedulerTab.UseVisualStyleBackColor = true;
            // 
            // SchedulerPg
            // 
            this.SchedulerPg.BackColor = System.Drawing.Color.White;
            this.SchedulerPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchedulerPg.Location = new System.Drawing.Point(3, 3);
            this.SchedulerPg.Name = "SchedulerPg";
            this.SchedulerPg.Size = new System.Drawing.Size(391, 261);
            this.SchedulerPg.TabIndex = 0;
            // 
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.PrimitivePg);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrimitiveTab.Size = new System.Drawing.Size(397, 267);
            this.PrimitiveTab.TabIndex = 1;
            this.PrimitiveTab.Text = "Primitive";
            this.PrimitiveTab.UseVisualStyleBackColor = true;
            // 
            // PrimitivePg
            // 
            this.PrimitivePg.BackColor = System.Drawing.Color.White;
            this.PrimitivePg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimitivePg.Location = new System.Drawing.Point(3, 3);
            this.PrimitivePg.Name = "PrimitivePg";
            this.PrimitivePg.Size = new System.Drawing.Size(391, 261);
            this.PrimitivePg.TabIndex = 0;
            // 
            // FiltersTab
            // 
            this.FiltersTab.Controls.Add(this.FiltersPg);
            this.FiltersTab.Location = new System.Drawing.Point(4, 4);
            this.FiltersTab.Name = "FiltersTab";
            this.FiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.FiltersTab.Size = new System.Drawing.Size(397, 267);
            this.FiltersTab.TabIndex = 3;
            this.FiltersTab.Text = "Filters";
            this.FiltersTab.UseVisualStyleBackColor = true;
            // 
            // FiltersPg
            // 
            this.FiltersPg.BackColor = System.Drawing.Color.White;
            this.FiltersPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersPg.Location = new System.Drawing.Point(3, 3);
            this.FiltersPg.Name = "FiltersPg";
            this.FiltersPg.Size = new System.Drawing.Size(391, 261);
            this.FiltersPg.TabIndex = 0;
            // 
            // ITPacketTxt
            // 
            this.ITPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITPacketTxt.ItemHeight = 13;
            this.ITPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.ITPacketTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ITPacketTxt.Name = "ITPacketTxt";
            this.ITPacketTxt.Size = new System.Drawing.Size(254, 21);
            this.ITPacketTxt.TabIndex = 8;
            // 
            // ToolboxTab
            // 
            this.ToolboxTab.Controls.Add(this.ToolboxPg);
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToolboxTab.Size = new System.Drawing.Size(476, 313);
            this.ToolboxTab.TabIndex = 3;
            this.ToolboxTab.Text = "Toolbox";
            this.ToolboxTab.UseVisualStyleBackColor = true;
            // 
            // ToolboxPg
            // 
            this.ToolboxPg.BackColor = System.Drawing.Color.White;
            this.ToolboxPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolboxPg.Location = new System.Drawing.Point(3, 3);
            this.ToolboxPg.Name = "ToolboxPg";
            this.ToolboxPg.Size = new System.Drawing.Size(470, 307);
            this.ToolboxPg.TabIndex = 0;
            // 
            // ModulesTab
            // 
            this.ModulesTab.AllowDrop = true;
            this.ModulesTab.Controls.Add(this.ModulesPg);
            this.ModulesTab.Location = new System.Drawing.Point(4, 28);
            this.ModulesTab.Name = "ModulesTab";
            this.ModulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModulesTab.Size = new System.Drawing.Size(476, 313);
            this.ModulesTab.TabIndex = 1;
            this.ModulesTab.Text = "Modules";
            this.ModulesTab.UseVisualStyleBackColor = true;
            // 
            // ModulesPg
            // 
            this.ModulesPg.BackColor = System.Drawing.Color.White;
            this.ModulesPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModulesPg.Location = new System.Drawing.Point(3, 3);
            this.ModulesPg.Name = "ModulesPg";
            this.ModulesPg.Size = new System.Drawing.Size(470, 307);
            this.ModulesPg.TabIndex = 0;
            // 
            // OptionsTab
            // 
            this.OptionsTab.Controls.Add(this.OptionsPg);
            this.OptionsTab.Location = new System.Drawing.Point(4, 28);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(476, 313);
            this.OptionsTab.TabIndex = 5;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // OptionsPg
            // 
            this.OptionsPg.BackColor = System.Drawing.Color.White;
            this.OptionsPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPg.Location = new System.Drawing.Point(3, 3);
            this.OptionsPg.Name = "OptionsPg";
            this.OptionsPg.Size = new System.Drawing.Size(470, 307);
            this.OptionsPg.TabIndex = 0;
            // 
            // InjectionMenu
            // 
            this.InjectionMenu.InputBox = null;
            this.InjectionMenu.Name = "InjectionMenu";
            this.InjectionMenu.Size = new System.Drawing.Size(174, 170);
            // 
            // SavePacketDlg
            // 
            this.SavePacketDlg.DefaultExt = "pkt";
            this.SavePacketDlg.Filter = "Packet (*.pkt)|*.pkt";
            this.SavePacketDlg.Title = "Tanji ~ Save Packet";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Disconnected";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.TanjiTabs.ResumeLayout(false);
            this.ConnectionTab.ResumeLayout(false);
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTabs.ResumeLayout(false);
            this.ConstructerTab.ResumeLayout(false);
            this.SchedulerTab.ResumeLayout(false);
            this.PrimitiveTab.ResumeLayout(false);
            this.FiltersTab.ResumeLayout(false);
            this.ToolboxTab.ResumeLayout(false);
            this.ModulesTab.ResumeLayout(false);
            this.OptionsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        internal System.Windows.Forms.ToolStripStatusLabel ModulesTxt;
        internal System.Windows.Forms.ToolStripStatusLabel SchedulesTxt;
        internal System.Windows.Forms.ToolStripStatusLabel TanjiVersionTxt;
        public Sulakore.Components.SKoreInjectionMenu InjectionMenu;
        internal System.Windows.Forms.ToolStripStatusLabel FiltersTxt;
        private System.Windows.Forms.TabPage OptionsTab;
        private System.Windows.Forms.TabPage ModulesTab;
        private System.Windows.Forms.TabPage ToolboxTab;
        private System.Windows.Forms.TabPage InjectionTab;
        internal Sulakore.Components.SKoreButton ITSendToClientBtn;
        internal Sulakore.Components.SKoreButton ITSendToServerBtn;
        internal Sulakore.Components.SKoreTabControl InjectionTabs;
        internal System.Windows.Forms.TabPage ConstructerTab;
        internal System.Windows.Forms.TabPage SchedulerTab;
        internal System.Windows.Forms.TabPage PrimitiveTab;
        internal System.Windows.Forms.TabPage FiltersTab;
        internal System.Windows.Forms.ComboBox ITPacketTxt;
        private System.Windows.Forms.TabPage ConnectionTab;
        internal Sulakore.Components.SKoreTabControl TanjiTabs;
        internal System.Windows.Forms.OpenFileDialog InstallModuleDlg;
        internal System.Windows.Forms.SaveFileDialog SavePacketDlg;
        internal System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;
        private Components.Pages.ConnectionPage ConnectionPg;
        private Components.Pages.OptionsPage OptionsPg;
        private Components.Pages.ConstructerPage ConstructerPg;
        private Components.Pages.SchedulerPage SchedulerPg;
        private Components.Pages.PrimitivePage PrimitivePg;
        private Components.Pages.FiltersPage FiltersPg;
        private Components.Pages.ToolboxPage ToolboxPg;
        private Components.Pages.ModulesPage ModulesPg;
    }
}