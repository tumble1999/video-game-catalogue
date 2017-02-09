namespace VideoGameCatalogue
{
    partial class NewReview
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
            this.reviewTextTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBad = new System.Windows.Forms.Button();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewTextTextBox
            // 
            this.reviewTextTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.reviewTextTextBox.Location = new System.Drawing.Point(0, 0);
            this.reviewTextTextBox.Multiline = true;
            this.reviewTextTextBox.Name = "reviewTextTextBox";
            this.reviewTextTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reviewTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewTextTextBox.Size = new System.Drawing.Size(283, 130);
            this.reviewTextTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBad);
            this.panel2.Controls.Add(this.buttonGood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 126);
            this.panel2.TabIndex = 2;
            // 
            // buttonBad
            // 
            this.buttonBad.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBad.Location = new System.Drawing.Point(141, 0);
            this.buttonBad.Name = "buttonBad";
            this.buttonBad.Size = new System.Drawing.Size(142, 126);
            this.buttonBad.TabIndex = 1;
            this.buttonBad.Text = "Bad";
            this.buttonBad.UseVisualStyleBackColor = true;
            this.buttonBad.Click += new System.EventHandler(this.buttonBad_Click);
            // 
            // buttonGood
            // 
            this.buttonGood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGood.BackColor = System.Drawing.Color.Lime;
            this.buttonGood.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGood.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGood.Location = new System.Drawing.Point(0, 0);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(142, 126);
            this.buttonGood.TabIndex = 0;
            this.buttonGood.Text = "Good";
            this.buttonGood.UseVisualStyleBackColor = false;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancel.Location = new System.Drawing.Point(0, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(283, 28);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(283, 284);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reviewTextTextBox);
            this.Name = "NewReview";
            this.Text = "NewReview";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reviewTextTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBad;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonCancel;
    }
}