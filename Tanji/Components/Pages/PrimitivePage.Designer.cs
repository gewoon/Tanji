namespace Tanji.Components.Pages
{
    partial class PrimitivePage
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
            this.SaveAsBtn = new Sulakore.Components.SKoreButton();
            this.LengthTxt = new Sulakore.Components.SKoreLabelBox();
            this.HeaderTxt = new Sulakore.Components.SKoreLabelBox();
            this.CorruptedTxt = new Sulakore.Components.SKoreLabelBox();
            this.PacketTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveAsBtn.Location = new System.Drawing.Point(301, 238);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(87, 20);
            this.SaveAsBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SaveAsBtn.TabIndex = 16;
            this.SaveAsBtn.Text = "Save As";
            // 
            // LengthTxt
            // 
            this.LengthTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LengthTxt.Location = new System.Drawing.Point(100, 238);
            this.LengthTxt.Name = "LengthTxt";
            this.LengthTxt.Size = new System.Drawing.Size(91, 20);
            this.LengthTxt.TabIndex = 15;
            this.LengthTxt.Text = "Length";
            this.LengthTxt.Value = "0";
            this.LengthTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LengthTxt.ValueReadOnly = true;
            // 
            // HeaderTxt
            // 
            this.HeaderTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HeaderTxt.Location = new System.Drawing.Point(3, 238);
            this.HeaderTxt.Name = "HeaderTxt";
            this.HeaderTxt.Size = new System.Drawing.Size(91, 20);
            this.HeaderTxt.TabIndex = 14;
            this.HeaderTxt.Text = "Header";
            this.HeaderTxt.Value = "0";
            this.HeaderTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeaderTxt.ValueReadOnly = true;
            // 
            // CorruptedTxt
            // 
            this.CorruptedTxt.BackColor = System.Drawing.Color.Firebrick;
            this.CorruptedTxt.Location = new System.Drawing.Point(197, 238);
            this.CorruptedTxt.Name = "CorruptedTxt";
            this.CorruptedTxt.Size = new System.Drawing.Size(98, 20);
            this.CorruptedTxt.TabIndex = 13;
            this.CorruptedTxt.Text = "Corrupted";
            this.CorruptedTxt.Value = "True";
            this.CorruptedTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CorruptedTxt.ValueReadOnly = true;
            // 
            // PacketTxt
            // 
            this.PacketTxt.Location = new System.Drawing.Point(3, 3);
            this.PacketTxt.MaxLength = 2147483647;
            this.PacketTxt.Multiline = true;
            this.PacketTxt.Name = "PacketTxt";
            this.PacketTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PacketTxt.Size = new System.Drawing.Size(385, 229);
            this.PacketTxt.TabIndex = 12;
            // 
            // PrimitivePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveAsBtn);
            this.Controls.Add(this.LengthTxt);
            this.Controls.Add(this.HeaderTxt);
            this.Controls.Add(this.CorruptedTxt);
            this.Controls.Add(this.PacketTxt);
            this.Name = "PrimitivePage";
            this.Size = new System.Drawing.Size(391, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton SaveAsBtn;
        private Sulakore.Components.SKoreLabelBox LengthTxt;
        private Sulakore.Components.SKoreLabelBox HeaderTxt;
        private Sulakore.Components.SKoreLabelBox CorruptedTxt;
        private System.Windows.Forms.TextBox PacketTxt;
    }
}
