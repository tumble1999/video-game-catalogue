namespace VideoGameCatalogue
{
    partial class GamesList
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountLoggedOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountLoggedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutVideoGameCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.userInfoLabelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userIDStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.usernameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loggedInStatusLabelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loggedInStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameTitle = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.gameDescriptionLabel = new System.Windows.Forms.Label();
            this.viewGameButton = new System.Windows.Forms.Button();
            this.gameItemPanel = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.gameItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.accountLoggedOutToolStripMenuItem,
            this.accountLoggedInToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1031, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // accountLoggedOutToolStripMenuItem
            // 
            this.accountLoggedOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.accountLoggedOutToolStripMenuItem.Name = "accountLoggedOutToolStripMenuItem";
            this.accountLoggedOutToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountLoggedOutToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // accountLoggedInToolStripMenuItem
            // 
            this.accountLoggedInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listReviewsToolStripMenuItem,
            this.toolStripSeparator3,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountLoggedInToolStripMenuItem.Name = "accountLoggedInToolStripMenuItem";
            this.accountLoggedInToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountLoggedInToolStripMenuItem.Text = "Account";
            // 
            // listReviewsToolStripMenuItem
            // 
            this.listReviewsToolStripMenuItem.Name = "listReviewsToolStripMenuItem";
            this.listReviewsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listReviewsToolStripMenuItem.Text = "List Reviews";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutVideoGameCatalogueToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // aboutVideoGameCatalogueToolStripMenuItem
            // 
            this.aboutVideoGameCatalogueToolStripMenuItem.Name = "aboutVideoGameCatalogueToolStripMenuItem";
            this.aboutVideoGameCatalogueToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.aboutVideoGameCatalogueToolStripMenuItem.Text = "About Video Game Catalogue";
            this.aboutVideoGameCatalogueToolStripMenuItem.Click += new System.EventHandler(this.aboutVideoGameCatalogueToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoLabelLabel,
            this.userIDStatusLabel,
            this.usernameStatusLabel,
            this.loggedInStatusLabelLabel,
            this.loggedInStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 526);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1031, 24);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // userInfoLabelLabel
            // 
            this.userInfoLabelLabel.Name = "userInfoLabelLabel";
            this.userInfoLabelLabel.Size = new System.Drawing.Size(33, 19);
            this.userInfoLabelLabel.Text = "User:";
            // 
            // userIDStatusLabel
            // 
            this.userIDStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userIDStatusLabel.Name = "userIDStatusLabel";
            this.userIDStatusLabel.Size = new System.Drawing.Size(104, 19);
            this.userIDStatusLabel.Text = "userIDStatusLabel";
            // 
            // usernameStatusLabel
            // 
            this.usernameStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.usernameStatusLabel.Name = "usernameStatusLabel";
            this.usernameStatusLabel.Size = new System.Drawing.Size(123, 19);
            this.usernameStatusLabel.Text = "usernameStatusLabel";
            // 
            // loggedInStatusLabelLabel
            // 
            this.loggedInStatusLabelLabel.Name = "loggedInStatusLabelLabel";
            this.loggedInStatusLabelLabel.Size = new System.Drawing.Size(60, 19);
            this.loggedInStatusLabelLabel.Text = "Logged in";
            // 
            // loggedInStatusLabel
            // 
            this.loggedInStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.loggedInStatusLabel.Name = "loggedInStatusLabel";
            this.loggedInStatusLabel.Size = new System.Drawing.Size(118, 19);
            this.loggedInStatusLabel.Text = "loggedInStatusLabel";
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(21, 11);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(133, 31);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "gameTitle";
            // 
            // genreText
            // 
            this.genreText.AutoSize = true;
            this.genreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genreText.Location = new System.Drawing.Point(24, 43);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(55, 13);
            this.genreText.TabIndex = 1;
            this.genreText.Text = "genreText";
            // 
            // gameDescriptionLabel
            // 
            this.gameDescriptionLabel.AutoEllipsis = true;
            this.gameDescriptionLabel.Location = new System.Drawing.Point(27, 60);
            this.gameDescriptionLabel.Name = "gameDescriptionLabel";
            this.gameDescriptionLabel.Size = new System.Drawing.Size(244, 35);
            this.gameDescriptionLabel.TabIndex = 2;
            this.gameDescriptionLabel.Text = "gameDescriptionLabel";
            // 
            // viewGameButton
            // 
            this.viewGameButton.Location = new System.Drawing.Point(133, 98);
            this.viewGameButton.Name = "viewGameButton";
            this.viewGameButton.Size = new System.Drawing.Size(138, 23);
            this.viewGameButton.TabIndex = 3;
            this.viewGameButton.Text = "viewGameButton";
            this.viewGameButton.UseVisualStyleBackColor = true;
            // 
            // gameItemPanel
            // 
            this.gameItemPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameItemPanel.Controls.Add(this.viewGameButton);
            this.gameItemPanel.Controls.Add(this.gameDescriptionLabel);
            this.gameItemPanel.Controls.Add(this.genreText);
            this.gameItemPanel.Controls.Add(this.gameTitle);
            this.gameItemPanel.Location = new System.Drawing.Point(0, 27);
            this.gameItemPanel.Name = "gameItemPanel";
            this.gameItemPanel.Size = new System.Drawing.Size(278, 127);
            this.gameItemPanel.TabIndex = 2;
            this.gameItemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameItemPanel_Paint);
            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 550);
            this.Controls.Add(this.gameItemPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "GamesList";
            this.Text = "Games List";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.gameItemPanel.ResumeLayout(false);
            this.gameItemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutVideoGameCatalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountLoggedOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountLoggedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel loggedInStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel usernameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userIDStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userInfoLabelLabel;
        private System.Windows.Forms.ToolStripStatusLabel loggedInStatusLabelLabel;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label genreText;
        private System.Windows.Forms.Label gameDescriptionLabel;
        private System.Windows.Forms.Button viewGameButton;
        private System.Windows.Forms.Panel gameItemPanel;
    }
}

