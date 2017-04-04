namespace VideoGameCatalogue
{
    partial class CompanyManager
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
            this.listViewGames = new System.Windows.Forms.ListView();
            this.columnHeaderCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGameGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonEditGame = new System.Windows.Forms.Button();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCompanies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewGames
            // 
            this.listViewGames.CheckBoxes = true;
            this.listViewGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCompany,
            this.columnHeaderGameName,
            this.columnHeaderGameGenre,
            this.columnHeaderPlatform,
            this.columnHeaderReleaseDate,
            this.columnHeaderDescription,
            this.columnHeaderGameID});
            this.listViewGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewGames.GridLines = true;
            this.listViewGames.LabelEdit = true;
            this.listViewGames.Location = new System.Drawing.Point(0, 0);
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.Size = new System.Drawing.Size(789, 363);
            this.listViewGames.TabIndex = 0;
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            this.listViewGames.View = System.Windows.Forms.View.Details;
            this.listViewGames.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewGames_ItemChecked);
            this.listViewGames.SelectedIndexChanged += new System.EventHandler(this.listViewGames_SelectedIndexChanged);
            // 
            // columnHeaderCompany
            // 
            this.columnHeaderCompany.Text = "Company";
            this.columnHeaderCompany.Width = 205;
            // 
            // columnHeaderGameName
            // 
            this.columnHeaderGameName.Text = "Name";
            // 
            // columnHeaderGameGenre
            // 
            this.columnHeaderGameGenre.Text = "Genre";
            // 
            // columnHeaderPlatform
            // 
            this.columnHeaderPlatform.Text = "Platform";
            // 
            // columnHeaderReleaseDate
            // 
            this.columnHeaderReleaseDate.Text = "ReleaseDate";
            this.columnHeaderReleaseDate.Width = 128;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 349;
            // 
            // columnHeaderGameID
            // 
            this.columnHeaderGameID.Text = "ID";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNewGame.Location = new System.Drawing.Point(0, 363);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 33);
            this.buttonNewGame.TabIndex = 1;
            this.buttonNewGame.Text = "New";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonEditGame
            // 
            this.buttonEditGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonEditGame.Enabled = false;
            this.buttonEditGame.Location = new System.Drawing.Point(75, 363);
            this.buttonEditGame.Name = "buttonEditGame";
            this.buttonEditGame.Size = new System.Drawing.Size(75, 33);
            this.buttonEditGame.TabIndex = 2;
            this.buttonEditGame.Text = "Edit";
            this.buttonEditGame.UseVisualStyleBackColor = true;
            this.buttonEditGame.Click += new System.EventHandler(this.buttonEditGame_Click);
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeleteGame.Enabled = false;
            this.buttonDeleteGame.Location = new System.Drawing.Point(150, 363);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(75, 33);
            this.buttonDeleteGame.TabIndex = 3;
            this.buttonDeleteGame.Text = "Delete";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOk.Location = new System.Drawing.Point(714, 363);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 33);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(639, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCompanies
            // 
            this.buttonCompanies.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCompanies.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCompanies.Location = new System.Drawing.Point(564, 363);
            this.buttonCompanies.Name = "buttonCompanies";
            this.buttonCompanies.Size = new System.Drawing.Size(75, 33);
            this.buttonCompanies.TabIndex = 6;
            this.buttonCompanies.Text = "Companies";
            this.buttonCompanies.UseVisualStyleBackColor = true;
            this.buttonCompanies.Click += new System.EventHandler(this.buttonCompanies_Click);
            // 
            // CompanyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 396);
            this.Controls.Add(this.buttonCompanies);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDeleteGame);
            this.Controls.Add(this.buttonEditGame);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.listViewGames);
            this.DoubleBuffered = true;
            this.Name = "CompanyManager";
            this.Text = "Company Manager";
            this.Load += new System.EventHandler(this.CompanyManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.ColumnHeader columnHeaderCompany;
        private System.Windows.Forms.ColumnHeader columnHeaderGameName;
        private System.Windows.Forms.ColumnHeader columnHeaderGameGenre;
        private System.Windows.Forms.ColumnHeader columnHeaderPlatform;
        private System.Windows.Forms.ColumnHeader columnHeaderReleaseDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonEditGame;
        private System.Windows.Forms.Button buttonDeleteGame;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCompanies;
        private System.Windows.Forms.ColumnHeader columnHeaderGameID;
    }
}