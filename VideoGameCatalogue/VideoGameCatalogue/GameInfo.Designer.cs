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
            this.gamePublisherLabel = new System.Windows.Forms.Label();
            this.gamePlatformLabel = new System.Windows.Forms.Label();
            this.gameReleaseDateLabel = new System.Windows.Forms.Label();
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
            this.gameDescriptionLabel.AutoSize = true;
            this.gameDescriptionLabel.Location = new System.Drawing.Point(13, 91);
            this.gameDescriptionLabel.Name = "gameDescriptionLabel";
            this.gameDescriptionLabel.Size = new System.Drawing.Size(112, 13);
            this.gameDescriptionLabel.TabIndex = 2;
            this.gameDescriptionLabel.Text = "gameDescriptionLabel";
            // 
            // gamePublisherLabel
            // 
            this.gamePublisherLabel.AutoSize = true;
            this.gamePublisherLabel.Location = new System.Drawing.Point(12, 52);
            this.gamePublisherLabel.Name = "gamePublisherLabel";
            this.gamePublisherLabel.Size = new System.Drawing.Size(102, 13);
            this.gamePublisherLabel.TabIndex = 3;
            this.gamePublisherLabel.Text = "gamePublisherLabel";
            this.gamePublisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gamePlatformLabel
            // 
            this.gamePlatformLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePlatformLabel.AutoSize = true;
            this.gamePlatformLabel.Location = new System.Drawing.Point(494, 13);
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
            this.gameReleaseDateLabel.Location = new System.Drawing.Point(470, 33);
            this.gameReleaseDateLabel.Name = "gameReleaseDateLabel";
            this.gameReleaseDateLabel.Size = new System.Drawing.Size(121, 13);
            this.gameReleaseDateLabel.TabIndex = 5;
            this.gameReleaseDateLabel.Text = "gameReleaseDateLabel";
            this.gameReleaseDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 489);
            this.Controls.Add(this.gameReleaseDateLabel);
            this.Controls.Add(this.gamePlatformLabel);
            this.Controls.Add(this.gamePublisherLabel);
            this.Controls.Add(this.gameDescriptionLabel);
            this.Controls.Add(this.gameGenreLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.Name = "GameInfo";
            this.Text = "GameInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label gameGenreLabel;
        private System.Windows.Forms.Label gameDescriptionLabel;
        private System.Windows.Forms.Label gamePublisherLabel;
        private System.Windows.Forms.Label gamePlatformLabel;
        private System.Windows.Forms.Label gameReleaseDateLabel;
    }
}