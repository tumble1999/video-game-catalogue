namespace VideoGameCatalogue
{
    partial class FullReview
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
            this.reviewGoodBadText = new System.Windows.Forms.Label();
            this.reviewTextLabel = new System.Windows.Forms.Label();
            this.reviewTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reviewGoodBadText
            // 
            this.reviewGoodBadText.AutoSize = true;
            this.reviewGoodBadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewGoodBadText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reviewGoodBadText.Location = new System.Drawing.Point(27, 51);
            this.reviewGoodBadText.Name = "reviewGoodBadText";
            this.reviewGoodBadText.Size = new System.Drawing.Size(104, 13);
            this.reviewGoodBadText.TabIndex = 1;
            this.reviewGoodBadText.Text = "reviewGoodBadText";
            // 
            // reviewTextLabel
            // 
            this.reviewTextLabel.AutoEllipsis = true;
            this.reviewTextLabel.Location = new System.Drawing.Point(15, 90);
            this.reviewTextLabel.Name = "reviewTextLabel";
            this.reviewTextLabel.Size = new System.Drawing.Size(745, 389);
            this.reviewTextLabel.TabIndex = 2;
            this.reviewTextLabel.Text = "reviewTextLabel";
            // 
            // reviewTitle
            // 
            this.reviewTitle.AutoSize = true;
            this.reviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewTitle.Location = new System.Drawing.Point(12, 9);
            this.reviewTitle.Name = "reviewTitle";
            this.reviewTitle.Size = new System.Drawing.Size(448, 31);
            this.reviewTitle.TabIndex = 0;
            this.reviewTitle.Text = "Review of gameName by userName";
            // 
            // FullReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.reviewGoodBadText);
            this.Controls.Add(this.reviewTitle);
            this.Controls.Add(this.reviewTextLabel);
            this.Name = "FullReview";
            this.Text = "FullReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewGoodBadText;
        private System.Windows.Forms.Label reviewTextLabel;
        private System.Windows.Forms.Label reviewTitle;
    }
}