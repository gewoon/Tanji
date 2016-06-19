namespace Tanji.Components.Pages
{
    partial class ConstructerPage
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
            this.ValueTxt = new System.Windows.Forms.ComboBox();
            this.HeaderTxt = new System.Windows.Forms.NumericUpDown();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.CopyBtn = new Sulakore.Components.SKoreButton();
            this.AmountTxt = new System.Windows.Forms.NumericUpDown();
            this.RemoveBtn = new Sulakore.Components.SKoreButton();
            this.MoveDownBtn = new Sulakore.Components.SKoreButton();
            this.MoveUpBtn = new Sulakore.Components.SKoreButton();
            this.ClearBtn = new Sulakore.Components.SKoreButton();
            this.WriteByteBooleanBtn = new Sulakore.Components.SKoreButton();
            this.WriteStringBtn = new Sulakore.Components.SKoreButton();
            this.WriteIntegerBtn = new Sulakore.Components.SKoreButton();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.ConstructerVw = new Sulakore.Components.SKoreConstructView();
            this.TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StructureTxt = new Sulakore.Components.SKoreLabelBox();
            this.SaveBtn = new Sulakore.Components.SKoreButton();
            this.LoadBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueTxt
            // 
            this.ValueTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ValueTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ValueTxt.IntegralHeight = false;
            this.ValueTxt.ItemHeight = 13;
            this.ValueTxt.Location = new System.Drawing.Point(70, 16);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(252, 21);
            this.ValueTxt.TabIndex = 50;
            // 
            // HeaderTxt
            // 
            this.HeaderTxt.Location = new System.Drawing.Point(3, 17);
            this.HeaderTxt.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.HeaderTxt.Name = "HeaderTxt";
            this.HeaderTxt.Size = new System.Drawing.Size(61, 20);
            this.HeaderTxt.TabIndex = 66;
            this.HeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Location = new System.Drawing.Point(0, 1);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.HeaderLbl.TabIndex = 52;
            this.HeaderLbl.Text = "Header";
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(325, 1);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(43, 13);
            this.AmountLbl.TabIndex = 60;
            this.AmountLbl.Text = "Amount";
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.Transparent;
            this.CopyBtn.Location = new System.Drawing.Point(3, 238);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(69, 20);
            this.CopyBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CopyBtn.TabIndex = 64;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(328, 17);
            this.AmountTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.AmountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(60, 20);
            this.AmountTxt.TabIndex = 61;
            this.AmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.Location = new System.Drawing.Point(228, 238);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(69, 20);
            this.RemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.RemoveBtn.TabIndex = 59;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.MoveDownBtn.Enabled = false;
            this.MoveDownBtn.Location = new System.Drawing.Point(303, 238);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(85, 20);
            this.MoveDownBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MoveDownBtn.TabIndex = 58;
            this.MoveDownBtn.Text = "Move Down";
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.MoveUpBtn.Enabled = false;
            this.MoveUpBtn.Location = new System.Drawing.Point(303, 212);
            this.MoveUpBtn.Name = "MoveUpBtn";
            this.MoveUpBtn.Size = new System.Drawing.Size(85, 20);
            this.MoveUpBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MoveUpBtn.TabIndex = 57;
            this.MoveUpBtn.Text = "Move Up";
            this.MoveUpBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(3, 43);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(61, 20);
            this.ClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClearBtn.TabIndex = 56;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // WriteByteBooleanBtn
            // 
            this.WriteByteBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.WriteByteBooleanBtn.Location = new System.Drawing.Point(286, 43);
            this.WriteByteBooleanBtn.Name = "WriteByteBooleanBtn";
            this.WriteByteBooleanBtn.Size = new System.Drawing.Size(102, 20);
            this.WriteByteBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WriteByteBooleanBtn.TabIndex = 55;
            this.WriteByteBooleanBtn.Text = "Write Boolean";
            this.WriteByteBooleanBtn.Click += new System.EventHandler(this.WriteByteBooleanBtn_Click);
            // 
            // WriteStringBtn
            // 
            this.WriteStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.WriteStringBtn.Location = new System.Drawing.Point(178, 43);
            this.WriteStringBtn.Name = "WriteStringBtn";
            this.WriteStringBtn.Size = new System.Drawing.Size(102, 20);
            this.WriteStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WriteStringBtn.TabIndex = 54;
            this.WriteStringBtn.Text = "Write String";
            this.WriteStringBtn.Click += new System.EventHandler(this.WriteStringBtn_Click);
            // 
            // WriteIntegerBtn
            // 
            this.WriteIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.WriteIntegerBtn.Location = new System.Drawing.Point(70, 43);
            this.WriteIntegerBtn.Name = "WriteIntegerBtn";
            this.WriteIntegerBtn.Size = new System.Drawing.Size(102, 20);
            this.WriteIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WriteIntegerBtn.TabIndex = 53;
            this.WriteIntegerBtn.Text = "Write Integer";
            this.WriteIntegerBtn.Click += new System.EventHandler(this.WriteIntegerBtn_Click);
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(66, 0);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(34, 13);
            this.ValueLbl.TabIndex = 51;
            this.ValueLbl.Text = "Value";
            // 
            // ConstructerVw
            // 
            this.ConstructerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeCol,
            this.ValueCol,
            this.EncodedCol});
            this.ConstructerVw.FullRowSelect = true;
            this.ConstructerVw.GridLines = true;
            this.ConstructerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ConstructerVw.HideSelection = false;
            this.ConstructerVw.Location = new System.Drawing.Point(3, 69);
            this.ConstructerVw.MultiSelect = false;
            this.ConstructerVw.Name = "ConstructerVw";
            this.ConstructerVw.ShowItemToolTips = true;
            this.ConstructerVw.Size = new System.Drawing.Size(385, 137);
            this.ConstructerVw.TabIndex = 62;
            this.ConstructerVw.UseCompatibleStateImageBehavior = false;
            this.ConstructerVw.View = System.Windows.Forms.View.Details;
            // 
            // TypeCol
            // 
            this.TypeCol.Text = "Type";
            this.TypeCol.Width = 64;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 150;
            // 
            // EncodedCol
            // 
            this.EncodedCol.Text = "Encoded";
            this.EncodedCol.Width = 150;
            // 
            // StructureTxt
            // 
            this.StructureTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StructureTxt.Location = new System.Drawing.Point(3, 212);
            this.StructureTxt.Name = "StructureTxt";
            this.StructureTxt.Size = new System.Drawing.Size(294, 20);
            this.StructureTxt.TabIndex = 67;
            this.StructureTxt.Text = "Structure";
            this.StructureTxt.TextPaddingWidth = 18;
            this.StructureTxt.Value = "{l}{u:0}";
            this.StructureTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StructureTxt.ValueReadOnly = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Location = new System.Drawing.Point(78, 238);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(69, 20);
            this.SaveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SaveBtn.TabIndex = 68;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoadBtn.Location = new System.Drawing.Point(153, 238);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(69, 20);
            this.LoadBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LoadBtn.TabIndex = 69;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ConstructerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.HeaderTxt);
            this.Controls.Add(this.HeaderLbl);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.MoveDownBtn);
            this.Controls.Add(this.MoveUpBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.WriteByteBooleanBtn);
            this.Controls.Add(this.WriteStringBtn);
            this.Controls.Add(this.WriteIntegerBtn);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.ConstructerVw);
            this.Controls.Add(this.StructureTxt);
            this.Controls.Add(this.ValueTxt);
            this.Name = "ConstructerPage";
            this.Size = new System.Drawing.Size(391, 261);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.ColumnHeader TypeCol;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private System.Windows.Forms.ColumnHeader EncodedCol;
        private Sulakore.Components.SKoreLabelBox StructureTxt;
        private System.Windows.Forms.ComboBox ValueTxt;
        private System.Windows.Forms.NumericUpDown HeaderTxt;
        private Sulakore.Components.SKoreButton CopyBtn;
        private System.Windows.Forms.NumericUpDown AmountTxt;
        private Sulakore.Components.SKoreButton RemoveBtn;
        private Sulakore.Components.SKoreButton MoveDownBtn;
        private Sulakore.Components.SKoreButton MoveUpBtn;
        private Sulakore.Components.SKoreButton ClearBtn;
        private Sulakore.Components.SKoreButton WriteByteBooleanBtn;
        private Sulakore.Components.SKoreButton WriteStringBtn;
        private Sulakore.Components.SKoreButton WriteIntegerBtn;
        private Sulakore.Components.SKoreConstructView ConstructerVw;
        private Sulakore.Components.SKoreButton SaveBtn;
        private Sulakore.Components.SKoreButton LoadBtn;
    }
}
