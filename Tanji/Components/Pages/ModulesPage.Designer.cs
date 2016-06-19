namespace Tanji.Components.Pages
{
    partial class ModulesPage
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
            this.InstallPortTxt = new Sulakore.Components.SKoreLabelBox();
            this.DownloadsLbl = new Sulakore.Components.SKoreLabel();
            this.ReleasesBtn = new Sulakore.Components.SKoreButton();
            this.ResourceBtn = new Sulakore.Components.SKoreButton();
            this.MTHabboNameTxt = new System.Windows.Forms.TextBox();
            this.HabboNameLbl = new System.Windows.Forms.Label();
            this.AuthorsLbl = new System.Windows.Forms.Label();
            this.MTAuthorsTxt = new System.Windows.Forms.ComboBox();
            this.DownloadLatestBtn = new Sulakore.Components.SKoreButton();
            this.UninstallModuleBtn = new Sulakore.Components.SKoreButton();
            this.InstallModuleBtn = new Sulakore.Components.SKoreButton();
            this.ModulesVw = new Sulakore.Components.SKoreListView();
            this.MTNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTStateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // InstallPortTxt
            // 
            this.InstallPortTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InstallPortTxt.Location = new System.Drawing.Point(3, 284);
            this.InstallPortTxt.Name = "InstallPortTxt";
            this.InstallPortTxt.Size = new System.Drawing.Size(127, 20);
            this.InstallPortTxt.TabIndex = 29;
            this.InstallPortTxt.Text = "Install Port";
            this.InstallPortTxt.Value = "8055";
            this.InstallPortTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InstallPortTxt.ValueReadOnly = true;
            // 
            // DownloadsLbl
            // 
            this.DownloadsLbl.Location = new System.Drawing.Point(269, 232);
            this.DownloadsLbl.Name = "DownloadsLbl";
            this.DownloadsLbl.Size = new System.Drawing.Size(127, 20);
            this.DownloadsLbl.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DownloadsLbl.TabIndex = 28;
            this.DownloadsLbl.Text = "Downloads: 0";
            // 
            // ReleasesBtn
            // 
            this.ReleasesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReleasesBtn.Enabled = false;
            this.ReleasesBtn.Location = new System.Drawing.Point(269, 258);
            this.ReleasesBtn.Name = "ReleasesBtn";
            this.ReleasesBtn.Size = new System.Drawing.Size(127, 20);
            this.ReleasesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ReleasesBtn.TabIndex = 27;
            this.ReleasesBtn.Text = "Releases";
            // 
            // ResourceBtn
            // 
            this.ResourceBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResourceBtn.Enabled = false;
            this.ResourceBtn.Location = new System.Drawing.Point(3, 258);
            this.ResourceBtn.Name = "ResourceBtn";
            this.ResourceBtn.Size = new System.Drawing.Size(127, 20);
            this.ResourceBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ResourceBtn.TabIndex = 26;
            // 
            // MTHabboNameTxt
            // 
            this.MTHabboNameTxt.Location = new System.Drawing.Point(136, 232);
            this.MTHabboNameTxt.Name = "MTHabboNameTxt";
            this.MTHabboNameTxt.ReadOnly = true;
            this.MTHabboNameTxt.Size = new System.Drawing.Size(127, 20);
            this.MTHabboNameTxt.TabIndex = 25;
            this.MTHabboNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HabboNameLbl
            // 
            this.HabboNameLbl.AutoSize = true;
            this.HabboNameLbl.Location = new System.Drawing.Point(133, 215);
            this.HabboNameLbl.Name = "HabboNameLbl";
            this.HabboNameLbl.Size = new System.Drawing.Size(70, 13);
            this.HabboNameLbl.TabIndex = 24;
            this.HabboNameLbl.Text = "Habbo Name";
            // 
            // AuthorsLbl
            // 
            this.AuthorsLbl.AutoSize = true;
            this.AuthorsLbl.Location = new System.Drawing.Point(0, 215);
            this.AuthorsLbl.Name = "AuthorsLbl";
            this.AuthorsLbl.Size = new System.Drawing.Size(49, 13);
            this.AuthorsLbl.TabIndex = 23;
            this.AuthorsLbl.Text = "Author(s)";
            // 
            // MTAuthorsTxt
            // 
            this.MTAuthorsTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MTAuthorsTxt.Enabled = false;
            this.MTAuthorsTxt.FormattingEnabled = true;
            this.MTAuthorsTxt.Location = new System.Drawing.Point(3, 231);
            this.MTAuthorsTxt.Name = "MTAuthorsTxt";
            this.MTAuthorsTxt.Size = new System.Drawing.Size(127, 21);
            this.MTAuthorsTxt.TabIndex = 22;
            // 
            // DownloadLatestBtn
            // 
            this.DownloadLatestBtn.BackColor = System.Drawing.Color.Transparent;
            this.DownloadLatestBtn.Enabled = false;
            this.DownloadLatestBtn.Location = new System.Drawing.Point(136, 258);
            this.DownloadLatestBtn.Name = "DownloadLatestBtn";
            this.DownloadLatestBtn.Size = new System.Drawing.Size(127, 20);
            this.DownloadLatestBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DownloadLatestBtn.TabIndex = 21;
            this.DownloadLatestBtn.Text = "View Latest";
            // 
            // UninstallModuleBtn
            // 
            this.UninstallModuleBtn.BackColor = System.Drawing.Color.Transparent;
            this.UninstallModuleBtn.Enabled = false;
            this.UninstallModuleBtn.Location = new System.Drawing.Point(136, 284);
            this.UninstallModuleBtn.Name = "UninstallModuleBtn";
            this.UninstallModuleBtn.Size = new System.Drawing.Size(127, 20);
            this.UninstallModuleBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.UninstallModuleBtn.TabIndex = 20;
            this.UninstallModuleBtn.Text = "Uninstall Module";
            // 
            // InstallModuleBtn
            // 
            this.InstallModuleBtn.BackColor = System.Drawing.Color.Transparent;
            this.InstallModuleBtn.Location = new System.Drawing.Point(269, 284);
            this.InstallModuleBtn.Name = "InstallModuleBtn";
            this.InstallModuleBtn.Size = new System.Drawing.Size(127, 20);
            this.InstallModuleBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InstallModuleBtn.TabIndex = 19;
            this.InstallModuleBtn.Text = "Install Module";
            // 
            // ModulesVw
            // 
            this.ModulesVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MTNameCol,
            this.MTDescriptionCol,
            this.MTVersionCol,
            this.MTStateCol});
            this.ModulesVw.FullRowSelect = true;
            this.ModulesVw.GridLines = true;
            this.ModulesVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ModulesVw.HideSelection = false;
            this.ModulesVw.Location = new System.Drawing.Point(3, 3);
            this.ModulesVw.MultiSelect = false;
            this.ModulesVw.Name = "ModulesVw";
            this.ModulesVw.ShowItemToolTips = true;
            this.ModulesVw.Size = new System.Drawing.Size(464, 209);
            this.ModulesVw.TabIndex = 17;
            this.ModulesVw.UseCompatibleStateImageBehavior = false;
            this.ModulesVw.View = System.Windows.Forms.View.Details;
            // 
            // MTNameCol
            // 
            this.MTNameCol.Text = "Name";
            this.MTNameCol.Width = 98;
            // 
            // MTDescriptionCol
            // 
            this.MTDescriptionCol.Text = "Description";
            this.MTDescriptionCol.Width = 215;
            // 
            // MTVersionCol
            // 
            this.MTVersionCol.Text = "Version";
            this.MTVersionCol.Width = 68;
            // 
            // MTStateCol
            // 
            this.MTStateCol.Text = "State";
            this.MTStateCol.Width = 68;
            // 
            // ModulesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstallPortTxt);
            this.Controls.Add(this.DownloadsLbl);
            this.Controls.Add(this.ReleasesBtn);
            this.Controls.Add(this.ResourceBtn);
            this.Controls.Add(this.MTHabboNameTxt);
            this.Controls.Add(this.HabboNameLbl);
            this.Controls.Add(this.AuthorsLbl);
            this.Controls.Add(this.MTAuthorsTxt);
            this.Controls.Add(this.DownloadLatestBtn);
            this.Controls.Add(this.UninstallModuleBtn);
            this.Controls.Add(this.InstallModuleBtn);
            this.Controls.Add(this.ModulesVw);
            this.Name = "ModulesPage";
            this.Size = new System.Drawing.Size(470, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreLabelBox InstallPortTxt;
        private System.Windows.Forms.Label AuthorsLbl;
        private System.Windows.Forms.ColumnHeader MTNameCol;
        private System.Windows.Forms.ColumnHeader MTDescriptionCol;
        private System.Windows.Forms.ColumnHeader MTVersionCol;
        private System.Windows.Forms.ColumnHeader MTStateCol;
        private Sulakore.Components.SKoreLabel DownloadsLbl;
        private Sulakore.Components.SKoreButton ReleasesBtn;
        private Sulakore.Components.SKoreButton ResourceBtn;
        private System.Windows.Forms.TextBox MTHabboNameTxt;
        private System.Windows.Forms.Label HabboNameLbl;
        private System.Windows.Forms.ComboBox MTAuthorsTxt;
        private Sulakore.Components.SKoreButton DownloadLatestBtn;
        private Sulakore.Components.SKoreButton UninstallModuleBtn;
        private Sulakore.Components.SKoreButton InstallModuleBtn;
        private Sulakore.Components.SKoreListView ModulesVw;
    }
}
