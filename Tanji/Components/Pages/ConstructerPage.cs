using System;
using System.ComponentModel;
using System.Windows.Forms;
using Sulakore.Protocol;

namespace Tanji.Components.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ConstructerPage : PageControl, IRetrievable
    {
        private ushort _header = 0;
        /// <summary>
        /// Gets or sets the header to use for the constructed packet.
        /// </summary>
        [DefaultValue(typeof(ushort), "0")]
        [Description("The header to use for the constructed packet.")]
        public ushort Header
        {
            get { return _header; }
            set
            {
                _header = value;
                RaiseOnPropertyChanged(nameof(Header));
            }
        }

        private ushort _amount = 1;
        /// <summary>
        /// Gets or sets the amount of times to write any given value.
        /// </summary>
        [DefaultValue(typeof(ushort), "1")]
        [Description("The amount of times to write any given value.")]
        public ushort Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                RaiseOnPropertyChanged(nameof(Amount));
            }
        }

        private string _value = string.Empty;
        /// <summary>
        /// Gets or sets the string representation value of the object to write.
        /// </summary>
        [DefaultValue("")]
        [Description("The string representation value of the object to write.")]
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaiseOnPropertyChanged(nameof(Value));
            }
        }

        private string _structure = "{l}{u:0}";
        /// <summary>
        /// Gets or sets the string representation of the packet's structure using primitive type values.
        /// </summary>
        [DefaultValue("{l}{u:0}")]
        [Description("The string representation of the packet's structure using primitive type values.")]
        public string Structure
        {
            get { return _structure; }
            set
            {
                _structure = value;
                RaiseOnPropertyChanged(nameof(Structure));
            }
        }

        public ConstructerPage()
        {
            InitializeComponent();

            Bind(ValueTxt, "Text", nameof(Value));
            Bind(AmountTxt, "Value", nameof(Amount));
            Bind(HeaderTxt, "Value", nameof(Header));
            Bind(StructureTxt, "Value", nameof(Structure));
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Structure);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        { }
        private void LoadBtn_Click(object sender, EventArgs e)
        { }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ConstructerVw.ClearItems();
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            ConstructerVw.RemoveSelectedItem();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            ConstructerVw.MoveSelectedItemUp();
        }
        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            ConstructerVw.MoveSelectedItemDown();
        }

        private void WriteStringBtn_Click(object sender, EventArgs e) => WriteString();
        private void WriteIntegerBtn_Click(object sender, EventArgs e) => WriteInteger();
        private void WriteByteBooleanBtn_Click(object sender, EventArgs e) => WriteBoolean();

        public void WriteString()
        {
            ConstructerVw.WriteString(Value, Amount);
        }
        public void WriteInteger()
        {
        }
        public void WriteBoolean()
        { }

        #region IRetrievable Implementation
        public HMessage GetPacket() => ConstructerVw.GetPacket(Header);
        #endregion
    }
}