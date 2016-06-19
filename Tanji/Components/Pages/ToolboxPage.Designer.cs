namespace Tanji.Components.Pages
{
    partial class ToolboxPage
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
            this.TT16BitInputLbl = new System.Windows.Forms.Label();
            this.TT32BitInputLbl = new System.Windows.Forms.Label();
            this.TTIntInputTxt = new System.Windows.Forms.NumericUpDown();
            this.TTIntOutputTxt = new System.Windows.Forms.TextBox();
            this.TTUShortOutputTxt = new System.Windows.Forms.TextBox();
            this.TTDecodeIntBtn = new Sulakore.Components.SKoreButton();
            this.TTDecodeUShortBtn = new Sulakore.Components.SKoreButton();
            this.TTUShortInputTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // TT16BitInputLbl
            // 
            this.TT16BitInputLbl.AutoSize = true;
            this.TT16BitInputLbl.Location = new System.Drawing.Point(3, 261);
            this.TT16BitInputLbl.Name = "TT16BitInputLbl";
            this.TT16BitInputLbl.Size = new System.Drawing.Size(100, 13);
            this.TT16BitInputLbl.TabIndex = 58;
            this.TT16BitInputLbl.Text = "16-Bit Integer Input:";
            // 
            // TT32BitInputLbl
            // 
            this.TT32BitInputLbl.AutoSize = true;
            this.TT32BitInputLbl.Location = new System.Drawing.Point(3, 287);
            this.TT32BitInputLbl.Name = "TT32BitInputLbl";
            this.TT32BitInputLbl.Size = new System.Drawing.Size(100, 13);
            this.TT32BitInputLbl.TabIndex = 51;
            this.TT32BitInputLbl.Text = "32-Bit Integer Input:";
            // 
            // TTIntInputTxt
            // 
            this.TTIntInputTxt.Location = new System.Drawing.Point(105, 284);
            this.TTIntInputTxt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TTIntInputTxt.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.TTIntInputTxt.Name = "TTIntInputTxt";
            this.TTIntInputTxt.Size = new System.Drawing.Size(126, 20);
            this.TTIntInputTxt.TabIndex = 52;
            this.TTIntInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTIntOutputTxt
            // 
            this.TTIntOutputTxt.Location = new System.Drawing.Point(237, 284);
            this.TTIntOutputTxt.Name = "TTIntOutputTxt";
            this.TTIntOutputTxt.Size = new System.Drawing.Size(126, 20);
            this.TTIntOutputTxt.TabIndex = 55;
            this.TTIntOutputTxt.Text = "[0][0][0][0]";
            this.TTIntOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTUShortOutputTxt
            // 
            this.TTUShortOutputTxt.Location = new System.Drawing.Point(237, 258);
            this.TTUShortOutputTxt.Name = "TTUShortOutputTxt";
            this.TTUShortOutputTxt.Size = new System.Drawing.Size(126, 20);
            this.TTUShortOutputTxt.TabIndex = 56;
            this.TTUShortOutputTxt.Text = "[0][0]";
            this.TTUShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTDecodeIntBtn
            // 
            this.TTDecodeIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeIntBtn.Location = new System.Drawing.Point(369, 284);
            this.TTDecodeIntBtn.Name = "TTDecodeIntBtn";
            this.TTDecodeIntBtn.Size = new System.Drawing.Size(98, 20);
            this.TTDecodeIntBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeIntBtn.TabIndex = 53;
            this.TTDecodeIntBtn.Text = "Decode Int32";
            // 
            // TTDecodeUShortBtn
            // 
            this.TTDecodeUShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeUShortBtn.Location = new System.Drawing.Point(369, 258);
            this.TTDecodeUShortBtn.Name = "TTDecodeUShortBtn";
            this.TTDecodeUShortBtn.Size = new System.Drawing.Size(98, 20);
            this.TTDecodeUShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeUShortBtn.TabIndex = 54;
            this.TTDecodeUShortBtn.Text = "Decode UInt16";
            // 
            // TTUShortInputTxt
            // 
            this.TTUShortInputTxt.Location = new System.Drawing.Point(105, 258);
            this.TTUShortInputTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TTUShortInputTxt.Name = "TTUShortInputTxt";
            this.TTUShortInputTxt.Size = new System.Drawing.Size(126, 20);
            this.TTUShortInputTxt.TabIndex = 57;
            this.TTUShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolboxPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TT16BitInputLbl);
            this.Controls.Add(this.TT32BitInputLbl);
            this.Controls.Add(this.TTIntInputTxt);
            this.Controls.Add(this.TTIntOutputTxt);
            this.Controls.Add(this.TTUShortOutputTxt);
            this.Controls.Add(this.TTDecodeIntBtn);
            this.Controls.Add(this.TTDecodeUShortBtn);
            this.Controls.Add(this.TTUShortInputTxt);
            this.Name = "ToolboxPage";
            this.Size = new System.Drawing.Size(470, 307);
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TT16BitInputLbl;
        private System.Windows.Forms.Label TT32BitInputLbl;
        internal System.Windows.Forms.NumericUpDown TTIntInputTxt;
        internal System.Windows.Forms.TextBox TTIntOutputTxt;
        internal System.Windows.Forms.TextBox TTUShortOutputTxt;
        internal Sulakore.Components.SKoreButton TTDecodeIntBtn;
        internal Sulakore.Components.SKoreButton TTDecodeUShortBtn;
        internal System.Windows.Forms.NumericUpDown TTUShortInputTxt;
    }
}
