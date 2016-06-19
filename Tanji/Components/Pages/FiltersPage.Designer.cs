namespace Tanji.Components.Pages
{
    partial class FiltersPage
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
            this.ReplacementTxt = new Sulakore.Components.SKoreLabelBox();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.DestinationTxt = new System.Windows.Forms.ComboBox();
            this.HeaderTxt = new System.Windows.Forms.NumericUpDown();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new Sulakore.Components.SKoreButton();
            this.CreateBtn = new Sulakore.Components.SKoreButton();
            this.ActionLbl = new System.Windows.Forms.Label();
            this.ActionTxt = new System.Windows.Forms.ComboBox();
            this.FiltersVw = new Sulakore.Components.SKoreListView();
            this.FTHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTActionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTReplacementCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // ReplacementTxt
            // 
            this.ReplacementTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ReplacementTxt.Location = new System.Drawing.Point(3, 238);
            this.ReplacementTxt.Name = "ReplacementTxt";
            this.ReplacementTxt.Size = new System.Drawing.Size(385, 20);
            this.ReplacementTxt.TabIndex = 64;
            this.ReplacementTxt.Text = "Replacement";
            this.ReplacementTxt.Value = "";
            this.ReplacementTxt.ValueReadOnly = true;
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(63, 195);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.DestinationLbl.TabIndex = 63;
            this.DestinationLbl.Text = "Destination";
            // 
            // DestinationTxt
            // 
            this.DestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationTxt.FormattingEnabled = true;
            this.DestinationTxt.Location = new System.Drawing.Point(66, 211);
            this.DestinationTxt.Name = "DestinationTxt";
            this.DestinationTxt.Size = new System.Drawing.Size(66, 21);
            this.DestinationTxt.TabIndex = 62;
            // 
            // HeaderTxt
            // 
            this.HeaderTxt.Location = new System.Drawing.Point(3, 212);
            this.HeaderTxt.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.HeaderTxt.Name = "HeaderTxt";
            this.HeaderTxt.Size = new System.Drawing.Size(57, 20);
            this.HeaderTxt.TabIndex = 61;
            this.HeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Location = new System.Drawing.Point(0, 196);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.HeaderLbl.TabIndex = 60;
            this.HeaderLbl.Text = "Header";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.Location = new System.Drawing.Point(302, 212);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(86, 20);
            this.RemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.RemoveBtn.TabIndex = 59;
            this.RemoveBtn.Text = "Remove";
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.Location = new System.Drawing.Point(210, 212);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(86, 20);
            this.CreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CreateBtn.TabIndex = 58;
            this.CreateBtn.Text = "Create";
            // 
            // ActionLbl
            // 
            this.ActionLbl.AutoSize = true;
            this.ActionLbl.Location = new System.Drawing.Point(135, 195);
            this.ActionLbl.Name = "ActionLbl";
            this.ActionLbl.Size = new System.Drawing.Size(37, 13);
            this.ActionLbl.TabIndex = 57;
            this.ActionLbl.Text = "Action";
            // 
            // ActionTxt
            // 
            this.ActionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionTxt.FormattingEnabled = true;
            this.ActionTxt.Location = new System.Drawing.Point(138, 211);
            this.ActionTxt.Name = "ActionTxt";
            this.ActionTxt.Size = new System.Drawing.Size(66, 21);
            this.ActionTxt.TabIndex = 56;
            // 
            // FiltersVw
            // 
            this.FiltersVw.CheckBoxes = true;
            this.FiltersVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FTHeaderCol,
            this.FTDestinationCol,
            this.FTActionCol,
            this.FTReplacementCol});
            this.FiltersVw.FullRowSelect = true;
            this.FiltersVw.GridLines = true;
            this.FiltersVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FiltersVw.HideSelection = false;
            this.FiltersVw.Location = new System.Drawing.Point(3, 3);
            this.FiltersVw.MultiSelect = false;
            this.FiltersVw.Name = "FiltersVw";
            this.FiltersVw.ShowItemToolTips = true;
            this.FiltersVw.Size = new System.Drawing.Size(385, 189);
            this.FiltersVw.TabIndex = 55;
            this.FiltersVw.UseCompatibleStateImageBehavior = false;
            this.FiltersVw.View = System.Windows.Forms.View.Details;
            // 
            // FTHeaderCol
            // 
            this.FTHeaderCol.Text = "Header";
            this.FTHeaderCol.Width = 55;
            // 
            // FTDestinationCol
            // 
            this.FTDestinationCol.Text = "Destination";
            this.FTDestinationCol.Width = 68;
            // 
            // FTActionCol
            // 
            this.FTActionCol.Text = "Action";
            this.FTActionCol.Width = 68;
            // 
            // FTReplacementCol
            // 
            this.FTReplacementCol.Text = "Replacement";
            this.FTReplacementCol.Width = 176;
            // 
            // FiltersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReplacementTxt);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.DestinationTxt);
            this.Controls.Add(this.HeaderTxt);
            this.Controls.Add(this.HeaderLbl);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ActionLbl);
            this.Controls.Add(this.ActionTxt);
            this.Controls.Add(this.FiltersVw);
            this.Name = "FiltersPage";
            this.Size = new System.Drawing.Size(391, 261);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label ActionLbl;
        private System.Windows.Forms.ColumnHeader FTHeaderCol;
        private System.Windows.Forms.ColumnHeader FTDestinationCol;
        private System.Windows.Forms.ColumnHeader FTActionCol;
        private System.Windows.Forms.ColumnHeader FTReplacementCol;
        private Sulakore.Components.SKoreLabelBox ReplacementTxt;
        private System.Windows.Forms.ComboBox DestinationTxt;
        private System.Windows.Forms.NumericUpDown HeaderTxt;
        private Sulakore.Components.SKoreButton RemoveBtn;
        private Sulakore.Components.SKoreButton CreateBtn;
        private System.Windows.Forms.ComboBox ActionTxt;
        private Sulakore.Components.SKoreListView FiltersVw;
    }
}
