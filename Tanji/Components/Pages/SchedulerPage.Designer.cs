namespace Tanji.Components.Pages
{
    partial class SchedulerPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoStartBx = new System.Windows.Forms.CheckBox();
            this.DestinationTxt = new System.Windows.Forms.ComboBox();
            this.PacketTxt = new System.Windows.Forms.TextBox();
            this.HotkeyTxt = new Sulakore.Components.SKoreLabelBox();
            this.RemoveBtn = new Sulakore.Components.SKoreButton();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.CyclesLbl = new System.Windows.Forms.Label();
            this.CyclesTxt = new System.Windows.Forms.NumericUpDown();
            this.IntervalLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new Sulakore.Components.SKoreButton();
            this.CreateBtn = new Sulakore.Components.SKoreButton();
            this.IntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.PacketLbl = new System.Windows.Forms.Label();
            this.SchedulerVw = new Sulakore.Components.SKoreSchedulerView();
            this.STPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STCyclesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STHotkeyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.CyclesTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoStartBx
            // 
            this.AutoStartBx.AutoSize = true;
            this.AutoStartBx.Checked = true;
            this.AutoStartBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoStartBx.Location = new System.Drawing.Point(126, 195);
            this.AutoStartBx.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.AutoStartBx.Name = "AutoStartBx";
            this.AutoStartBx.Size = new System.Drawing.Size(73, 17);
            this.AutoStartBx.TabIndex = 71;
            this.AutoStartBx.Text = "Auto Start";
            this.AutoStartBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoStartBx.UseVisualStyleBackColor = true;
            // 
            // DestinationTxt
            // 
            this.DestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationTxt.FormattingEnabled = true;
            this.DestinationTxt.Location = new System.Drawing.Point(199, 211);
            this.DestinationTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.DestinationTxt.Name = "DestinationTxt";
            this.DestinationTxt.Size = new System.Drawing.Size(66, 21);
            this.DestinationTxt.TabIndex = 67;
            // 
            // PacketTxt
            // 
            this.PacketTxt.Location = new System.Drawing.Point(4, 212);
            this.PacketTxt.MaxLength = 2147483647;
            this.PacketTxt.Name = "PacketTxt";
            this.PacketTxt.Size = new System.Drawing.Size(189, 20);
            this.PacketTxt.TabIndex = 65;
            // 
            // HotkeyTxt
            // 
            this.HotkeyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HotkeyTxt.Location = new System.Drawing.Point(199, 238);
            this.HotkeyTxt.Name = "HotkeyTxt";
            this.HotkeyTxt.Size = new System.Drawing.Size(190, 20);
            this.HotkeyTxt.TabIndex = 77;
            this.HotkeyTxt.Text = "Hotkey";
            this.HotkeyTxt.Value = "";
            this.HotkeyTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HotkeyTxt.ValueReadOnly = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.Location = new System.Drawing.Point(69, 238);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(59, 20);
            this.RemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.RemoveBtn.TabIndex = 76;
            this.RemoveBtn.Text = "Remove";
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(196, 196);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.DestinationLbl.TabIndex = 68;
            this.DestinationLbl.Text = "Destination";
            // 
            // CyclesLbl
            // 
            this.CyclesLbl.AutoSize = true;
            this.CyclesLbl.Location = new System.Drawing.Point(330, 196);
            this.CyclesLbl.Name = "CyclesLbl";
            this.CyclesLbl.Size = new System.Drawing.Size(38, 13);
            this.CyclesLbl.TabIndex = 75;
            this.CyclesLbl.Text = "Cycles";
            // 
            // CyclesTxt
            // 
            this.CyclesTxt.Location = new System.Drawing.Point(333, 212);
            this.CyclesTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CyclesTxt.Name = "CyclesTxt";
            this.CyclesTxt.Size = new System.Drawing.Size(56, 20);
            this.CyclesTxt.TabIndex = 74;
            this.CyclesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntervalLbl
            // 
            this.IntervalLbl.AutoSize = true;
            this.IntervalLbl.Location = new System.Drawing.Point(268, 196);
            this.IntervalLbl.Name = "IntervalLbl";
            this.IntervalLbl.Size = new System.Drawing.Size(42, 13);
            this.IntervalLbl.TabIndex = 70;
            this.IntervalLbl.Text = "Interval";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(134, 238);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(59, 20);
            this.ClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClearBtn.TabIndex = 73;
            this.ClearBtn.Text = "Clear";
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.Location = new System.Drawing.Point(4, 238);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(59, 20);
            this.CreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CreateBtn.TabIndex = 72;
            this.CreateBtn.Text = "Create";
            // 
            // IntervalTxt
            // 
            this.IntervalTxt.Location = new System.Drawing.Point(271, 212);
            this.IntervalTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.IntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalTxt.Name = "IntervalTxt";
            this.IntervalTxt.Size = new System.Drawing.Size(56, 20);
            this.IntervalTxt.TabIndex = 69;
            this.IntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PacketLbl
            // 
            this.PacketLbl.AutoSize = true;
            this.PacketLbl.Location = new System.Drawing.Point(1, 196);
            this.PacketLbl.Name = "PacketLbl";
            this.PacketLbl.Size = new System.Drawing.Size(41, 13);
            this.PacketLbl.TabIndex = 66;
            this.PacketLbl.Text = "Packet";
            // 
            // SchedulerVw
            // 
            this.SchedulerVw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchedulerVw.CheckBoxes = true;
            this.SchedulerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STPacketCol,
            this.STDestinationCol,
            this.STIntervalCol,
            this.STCyclesCol,
            this.STHotkeyCol});
            this.SchedulerVw.FullRowSelect = true;
            this.SchedulerVw.GridLines = true;
            this.SchedulerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SchedulerVw.HideSelection = false;
            this.SchedulerVw.Location = new System.Drawing.Point(3, 3);
            this.SchedulerVw.MultiSelect = false;
            this.SchedulerVw.Name = "SchedulerVw";
            this.SchedulerVw.ShowItemToolTips = true;
            this.SchedulerVw.Size = new System.Drawing.Size(385, 190);
            this.SchedulerVw.TabIndex = 64;
            this.SchedulerVw.UseCompatibleStateImageBehavior = false;
            this.SchedulerVw.View = System.Windows.Forms.View.Details;
            // 
            // STPacketCol
            // 
            this.STPacketCol.Text = "Packet";
            this.STPacketCol.Width = 120;
            // 
            // STDestinationCol
            // 
            this.STDestinationCol.Text = "Destination";
            this.STDestinationCol.Width = 73;
            // 
            // STIntervalCol
            // 
            this.STIntervalCol.Text = "Interval";
            this.STIntervalCol.Width = 53;
            // 
            // STCyclesCol
            // 
            this.STCyclesCol.Text = "Cycles";
            this.STCyclesCol.Width = 53;
            // 
            // STHotkeyCol
            // 
            this.STHotkeyCol.Text = "Hotkey";
            this.STHotkeyCol.Width = 65;
            // 
            // SchedulerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AutoStartBx);
            this.Controls.Add(this.DestinationTxt);
            this.Controls.Add(this.PacketTxt);
            this.Controls.Add(this.HotkeyTxt);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.CyclesLbl);
            this.Controls.Add(this.CyclesTxt);
            this.Controls.Add(this.IntervalLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.IntervalTxt);
            this.Controls.Add(this.PacketLbl);
            this.Controls.Add(this.SchedulerVw);
            this.Name = "SchedulerPage";
            this.Size = new System.Drawing.Size(391, 261);
            ((System.ComponentModel.ISupportInitialize)(this.CyclesTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoStartBx;
        private System.Windows.Forms.ComboBox DestinationTxt;
        private System.Windows.Forms.TextBox PacketTxt;
        private Sulakore.Components.SKoreLabelBox HotkeyTxt;
        private Sulakore.Components.SKoreButton RemoveBtn;
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.Label CyclesLbl;
        private System.Windows.Forms.NumericUpDown CyclesTxt;
        private System.Windows.Forms.Label IntervalLbl;
        private Sulakore.Components.SKoreButton ClearBtn;
        private Sulakore.Components.SKoreButton CreateBtn;
        private System.Windows.Forms.NumericUpDown IntervalTxt;
        private System.Windows.Forms.Label PacketLbl;
        private Sulakore.Components.SKoreSchedulerView SchedulerVw;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STCyclesCol;
        private System.Windows.Forms.ColumnHeader STHotkeyCol;
    }
}
