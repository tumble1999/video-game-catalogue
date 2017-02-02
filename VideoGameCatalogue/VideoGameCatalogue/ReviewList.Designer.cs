namespace VideoGameCatalogue
{
    partial class ReviewList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameItemPanel = new System.Windows.Forms.Panel();
            this.viewReviewButton = new System.Windows.Forms.Button();
            this.reviewTextLabel = new System.Windows.Forms.Label();
            this.reviewGoodBadText = new System.Windows.Forms.Label();
            this.reviewTitle = new System.Windows.Forms.Label();
            this.gameItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.gameTitleLabel.Location = new System.Drawing.Point(29, 9);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(289, 39);
            this.gameTitleLabel.TabIndex = 1;
            this.gameTitleLabel.Text = "Reviews from/for: ";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 520);
            this.panel1.TabIndex = 2;
            // 
            // gameItemPanel
            // 
            this.gameItemPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameItemPanel.Controls.Add(this.viewReviewButton);
            this.gameItemPanel.Controls.Add(this.reviewTextLabel);
            this.gameItemPanel.Controls.Add(this.reviewGoodBadText);
            this.gameItemPanel.Controls.Add(this.reviewTitle);
            this.gameItemPanel.Location = new System.Drawing.Point(3, 51);
            this.gameItemPanel.Name = "gameItemPanel";
            this.gameItemPanel.Size = new System.Drawing.Size(278, 127);
            this.gameItemPanel.TabIndex = 3;
            this.gameItemPanel.Visible = false;
            // 
            // viewReviewButton
            // 
            this.viewReviewButton.Location = new System.Drawing.Point(133, 98);
            this.viewReviewButton.Name = "viewReviewButton";
            this.viewReviewButton.Size = new System.Drawing.Size(138, 23);
            this.viewReviewButton.TabIndex = 3;
            this.viewReviewButton.Text = "viewReviewButton";
            this.viewReviewButton.UseVisualStyleBackColor = true;
            // 
            // reviewTextLabel
            // 
            this.reviewTextLabel.AutoEllipsis = true;
            this.reviewTextLabel.Location = new System.Drawing.Point(27, 60);
            this.reviewTextLabel.Name = "reviewTextLabel";
            this.reviewTextLabel.Size = new System.Drawing.Size(244, 35);
            this.reviewTextLabel.TabIndex = 2;
            this.reviewTextLabel.Text = "reviewTextLabel";
            // 
            // reviewGoodBadText
            // 
            this.reviewGoodBadText.AutoSize = true;
            this.reviewGoodBadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewGoodBadText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reviewGoodBadText.Location = new System.Drawing.Point(24, 43);
            this.reviewGoodBadText.Name = "reviewGoodBadText";
            this.reviewGoodBadText.Size = new System.Drawing.Size(104, 13);
            this.reviewGoodBadText.TabIndex = 1;
            this.reviewGoodBadText.Text = "reviewGoodBadText";
            // 
            // reviewTitle
            // 
            this.reviewTitle.AutoSize = true;
            this.reviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewTitle.Location = new System.Drawing.Point(12, 12);
            this.reviewTitle.Name = "reviewTitle";
            this.reviewTitle.Size = new System.Drawing.Size(145, 31);
            this.reviewTitle.TabIndex = 0;
            this.reviewTitle.Text = "reviewTitle";
            // 
            // ReviewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 571);
            this.Controls.Add(this.gameItemPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameTitleLabel);
            this.Name = "ReviewList";
            this.Text = "ReviewList";
            this.gameItemPanel.ResumeLayout(false);
            this.gameItemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel gameItemPanel;
        private System.Windows.Forms.Button viewReviewButton;
        private System.Windows.Forms.Label reviewTextLabel;
        private System.Windows.Forms.Label reviewGoodBadText;
        private System.Windows.Forms.Label reviewTitle;
    }
}