namespace VideoGameCatalogue
{
    partial class GameInfo
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
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.gameGenreLabel = new System.Windows.Forms.Label();
            this.gameDescriptionLabel = new System.Windows.Forms.Label();
            this.gamePlatformLabel = new System.Windows.Forms.Label();
            this.gameReleaseDateLabel = new System.Windows.Forms.Label();
            this.gameReviewBar = new System.Windows.Forms.ProgressBar();
            this.panelReviewbuttons = new System.Windows.Forms.Panel();
            this.buttonAllReviews = new System.Windows.Forms.Button();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.reviewCountLabel = new System.Windows.Forms.Label();
            this.linkLabelCompany = new System.Windows.Forms.LinkLabel();
            this.panelReviewbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(251, 39);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "gameTitleLabel";
            // 
            // gameGenreLabel
            // 
            this.gameGenreLabel.AutoSize = true;
            this.gameGenreLabel.Location = new System.Drawing.Point(176, 52);
            this.gameGenreLabel.Name = "gameGenreLabel";
            this.gameGenreLabel.Size = new System.Drawing.Size(88, 13);
            this.gameGenreLabel.TabIndex = 1;
            this.gameGenreLabel.Text = "gameGenreLabel";
            this.gameGenreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameDescriptionLabel
            // 
            this.gameDescriptionLabel.Location = new System.Drawing.Point(12, 102);
            this.gameDescriptionLabel.Name = "gameDescriptionLabel";
            this.gameDescriptionLabel.Size = new System.Drawing.Size(574, 267);
            this.gameDescriptionLabel.TabIndex = 2;
            this.gameDescriptionLabel.Text = "gameDescriptionLabel";
            // 
            // gamePlatformLabel
            // 
            this.gamePlatformLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePlatformLabel.AutoSize = true;
            this.gamePlatformLabel.Location = new System.Drawing.Point(505, 13);
            this.gamePlatformLabel.Name = "gamePlatformLabel";
            this.gamePlatformLabel.Size = new System.Drawing.Size(97, 13);
            this.gamePlatformLabel.TabIndex = 4;
            this.gamePlatformLabel.Text = "gamePlatformLabel";
            this.gamePlatformLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameReleaseDateLabel
            // 
            this.gameReleaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameReleaseDateLabel.AutoSize = true;
            this.gameReleaseDateLabel.Location = new System.Drawing.Point(482, 33);
            this.gameReleaseDateLabel.Name = "gameReleaseDateLabel";
            this.gameReleaseDateLabel.Size = new System.Drawing.Size(121, 13);
            this.gameReleaseDateLabel.TabIndex = 5;
            this.gameReleaseDateLabel.Text = "gameReleaseDateLabel";
            this.gameReleaseDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameReviewBar
            // 
            this.gameReviewBar.Location = new System.Drawing.Point(491, 52);
            this.gameReviewBar.Name = "gameReviewBar";
            this.gameReviewBar.Size = new System.Drawing.Size(100, 23);
            this.gameReviewBar.TabIndex = 6;
            // 
            // panelReviewbuttons
            // 
            this.panelReviewbuttons.Controls.Add(this.buttonAllReviews);
            this.panelReviewbuttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReviewbuttons.Location = new System.Drawing.Point(0, 450);
            this.panelReviewbuttons.Name = "panelReviewbuttons";
            this.panelReviewbuttons.Size = new System.Drawing.Size(603, 39);
            this.panelReviewbuttons.TabIndex = 7;
            // 
            // buttonAllReviews
            // 
            this.buttonAllReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAllReviews.Location = new System.Drawing.Point(0, 0);
            this.buttonAllReviews.Name = "buttonAllReviews";
            this.buttonAllReviews.Size = new System.Drawing.Size(603, 39);
            this.buttonAllReviews.TabIndex = 0;
            this.buttonAllReviews.Text = "Reviews";
            this.buttonAllReviews.UseVisualStyleBackColor = true;
            this.buttonAllReviews.Click += new System.EventHandler(this.buttonAllReviews_Click);
            // 
            // panelReviews
            // 
            this.panelReviews.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReviews.Location = new System.Drawing.Point(0, 381);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(603, 69);
            this.panelReviews.TabIndex = 8;
            // 
            // reviewCountLabel
            // 
            this.reviewCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reviewCountLabel.AutoSize = true;
            this.reviewCountLabel.Location = new System.Drawing.Point(510, 78);
            this.reviewCountLabel.Name = "reviewCountLabel";
            this.reviewCountLabel.Size = new System.Drawing.Size(92, 13);
            this.reviewCountLabel.TabIndex = 9;
            this.reviewCountLabel.Text = "reviewCountLabel";
            this.reviewCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkLabelCompany
            // 
            this.linkLabelCompany.AutoSize = true;
            this.linkLabelCompany.Location = new System.Drawing.Point(12, 62);
            this.linkLabelCompany.Name = "linkLabelCompany";
            this.linkLabelCompany.Size = new System.Drawing.Size(93, 13);
            this.linkLabelCompany.TabIndex = 10;
            this.linkLabelCompany.TabStop = true;
            this.linkLabelCompany.Text = "linkLabelCompany";
            this.linkLabelCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCompany_LinkClicked);
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 489);
            this.Controls.Add(this.linkLabelCompany);
            this.Controls.Add(this.reviewCountLabel);
            this.Controls.Add(this.panelReviews);
            this.Controls.Add(this.panelReviewbuttons);
            this.Controls.Add(this.gameReviewBar);
            this.Controls.Add(this.gameReleaseDateLabel);
            this.Controls.Add(this.gamePlatformLabel);
            this.Controls.Add(this.gameDescriptionLabel);
            this.Controls.Add(this.gameGenreLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.Name = "GameInfo";
            this.Text = "GameInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelReviewbuttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label gameGenreLabel;
        private System.Windows.Forms.Label gameDescriptionLabel;
        private System.Windows.Forms.Label gamePlatformLabel;
        private System.Windows.Forms.Label gameReleaseDateLabel;
        private System.Windows.Forms.ProgressBar gameReviewBar;
        private System.Windows.Forms.Panel panelReviewbuttons;
        private System.Windows.Forms.Panel panelReviews;
        private System.Windows.Forms.Button buttonAllReviews;
        private System.Windows.Forms.Label reviewCountLabel;
        private System.Windows.Forms.LinkLabel linkLabelCompany;
    }
}