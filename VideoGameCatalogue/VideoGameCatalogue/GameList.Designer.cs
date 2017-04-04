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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTitle = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.gameDescriptionLabel = new System.Windows.Forms.Label();
            this.viewGameButton = new System.Windows.Forms.Button();
            this.gameItemPanel = new System.Windows.Forms.Panel();
            this.gameListPanel = new System.Windows.Forms.Panel();
            this.labelGameListTitle = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.gameItemPanel.SuspendLayout();
            this.gameListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(485, 231);
            this.menuBar.Name = "menuBar";
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuBar.Size = new System.Drawing.Size(105, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.refreshToolStripMenuItem.Text = "Refresh Games";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(12, 12);
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
            this.gameItemPanel.Location = new System.Drawing.Point(6, 34);
            this.gameItemPanel.Name = "gameItemPanel";
            this.gameItemPanel.Size = new System.Drawing.Size(278, 127);
            this.gameItemPanel.TabIndex = 2;
            this.gameItemPanel.Visible = false;
            // 
            // gameListPanel
            // 
            this.gameListPanel.AutoScroll = true;
            this.gameListPanel.AutoSize = true;
            this.gameListPanel.Controls.Add(this.gameItemPanel);
            this.gameListPanel.Controls.Add(this.labelGameListTitle);
            this.gameListPanel.Controls.Add(this.menuBar);
            this.gameListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListPanel.Location = new System.Drawing.Point(0, 0);
            this.gameListPanel.Name = "gameListPanel";
            this.gameListPanel.Size = new System.Drawing.Size(1096, 550);
            this.gameListPanel.TabIndex = 3;
            // 
            // labelGameListTitle
            // 
            this.labelGameListTitle.AutoSize = true;
            this.labelGameListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGameListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameListTitle.Location = new System.Drawing.Point(0, 0);
            this.labelGameListTitle.Name = "labelGameListTitle";
            this.labelGameListTitle.Size = new System.Drawing.Size(239, 31);
            this.labelGameListTitle.TabIndex = 4;
            this.labelGameListTitle.Text = "labelGameListTitle";
            this.labelGameListTitle.Click += new System.EventHandler(this.labelGameListTitle_Click);
            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 24);
            this.ClientSize = new System.Drawing.Size(1096, 550);
            this.Controls.Add(this.gameListPanel);
            this.HelpButton = true;
            this.Name = "GamesList";
            this.Text = "Games List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeBegin += new System.EventHandler(this.GamesList_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.GamesList_ResizeEnd);
            this.Resize += new System.EventHandler(this.GamesList_Resize);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.gameItemPanel.ResumeLayout(false);
            this.gameItemPanel.PerformLayout();
            this.gameListPanel.ResumeLayout(false);
            this.gameListPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label genreText;
        private System.Windows.Forms.Label gameDescriptionLabel;
        private System.Windows.Forms.Button viewGameButton;
        private System.Windows.Forms.Panel gameItemPanel;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel gameListPanel;
        private System.Windows.Forms.Label labelGameListTitle;
    }
}

