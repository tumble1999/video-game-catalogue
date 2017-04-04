namespace VideoGameCatalogue
{
    partial class NewGame
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
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGameGenre = new System.Windows.Forms.Label();
            this.labelGameDescription = new System.Windows.Forms.Label();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.labelGamePlatform = new System.Windows.Forms.Label();
            this.labelGameReleaseDate = new System.Windows.Forms.Label();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.labelCompany = new System.Windows.Forms.Label();
            this.comboBoxComapny = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(84, 6);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(157, 20);
            this.textBoxGameName.TabIndex = 5;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(12, 9);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(66, 13);
            this.labelGameName.TabIndex = 4;
            this.labelGameName.Text = "Game Name";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(298, 6);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(138, 20);
            this.textBoxGenre.TabIndex = 7;
            // 
            // labelGameGenre
            // 
            this.labelGameGenre.AutoSize = true;
            this.labelGameGenre.Location = new System.Drawing.Point(256, 9);
            this.labelGameGenre.Name = "labelGameGenre";
            this.labelGameGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGameGenre.TabIndex = 6;
            this.labelGameGenre.Text = "Genre";
            // 
            // labelGameDescription
            // 
            this.labelGameDescription.AutoSize = true;
            this.labelGameDescription.Location = new System.Drawing.Point(18, 42);
            this.labelGameDescription.Name = "labelGameDescription";
            this.labelGameDescription.Size = new System.Drawing.Size(60, 13);
            this.labelGameDescription.TabIndex = 8;
            this.labelGameDescription.Text = "Description";
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(84, 114);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(157, 20);
            this.textBoxPlatform.TabIndex = 11;
            // 
            // labelGamePlatform
            // 
            this.labelGamePlatform.AutoSize = true;
            this.labelGamePlatform.Location = new System.Drawing.Point(33, 117);
            this.labelGamePlatform.Name = "labelGamePlatform";
            this.labelGamePlatform.Size = new System.Drawing.Size(45, 13);
            this.labelGamePlatform.TabIndex = 10;
            this.labelGamePlatform.Text = "Platform";
            // 
            // labelGameReleaseDate
            // 
            this.labelGameReleaseDate.AutoSize = true;
            this.labelGameReleaseDate.Location = new System.Drawing.Point(6, 149);
            this.labelGameReleaseDate.Name = "labelGameReleaseDate";
            this.labelGameReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.labelGameReleaseDate.TabIndex = 12;
            this.labelGameReleaseDate.Text = "Release Date";
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(84, 149);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReleaseDate.TabIndex = 13;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(256, 117);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(51, 13);
            this.labelCompany.TabIndex = 14;
            this.labelCompany.Text = "Company";
            // 
            // comboBoxComapny
            // 
            this.comboBoxComapny.FormattingEnabled = true;
            this.comboBoxComapny.Location = new System.Drawing.Point(315, 113);
            this.comboBoxComapny.Name = "comboBoxComapny";
            this.comboBoxComapny.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComapny.TabIndex = 15;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(84, 39);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(352, 49);
            this.textBoxDescription.TabIndex = 9;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 196);
            this.Controls.Add(this.comboBoxComapny);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.dateTimePickerReleaseDate);
            this.Controls.Add(this.labelGameReleaseDate);
            this.Controls.Add(this.textBoxPlatform);
            this.Controls.Add(this.labelGamePlatform);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelGameDescription);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGameGenre);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.labelGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewGame";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGameGenre;
        private System.Windows.Forms.Label labelGameDescription;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Label labelGamePlatform;
        private System.Windows.Forms.Label labelGameReleaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox comboBoxComapny;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}