﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public partial class MdiContainer : Form
    {

        AboutWindow aboutWindow = new AboutWindow();
        UserList userList = new UserList();
        private Thread updateLoop;

        /// <summary>
        /// 
        /// </summary>
        public MdiContainer()
        {
            InitializeComponent();
            this.updateLoop = new Thread(new ThreadStart(this.UpdateLoop));
            CurrentUser.Update();
            accountLoggedInToolStripMenuItem.Visible = CurrentUser.user.LoggedIn;
            accountLoggedOutToolStripMenuItem.Visible = !CurrentUser.user.LoggedIn;
            statusBar.Visible = statusBarToolStripMenuItem.Checked;
            loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            userIDStatusLabel.Text = CurrentUser.userID.ToString();
            usernameStatusLabel.Text = CurrentUser.username;
            updateLoop.Start();
            OpenWindow(new GamesList());
           
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateLoop()
        {
            while (true)
            {
                this.accountLoggedInToolStripMenuItem.Visible = CurrentUser.user.LoggedIn;
                this.accountLoggedOutToolStripMenuItem.Visible = !CurrentUser.user.LoggedIn;
            }
        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Visible = statusBarToolStripMenuItem.Checked;
        }

        public void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword().New("");
            new ChangePassword().New("face");
            new ChangePassword().Change(); ;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.user.Logout();
            CurrentUser.Update();
        }

        private void aboutVideoGameCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aboutWindow.ShowDialog();
        }
        

        private void ButtonClick(object sender, EventArgs e)
        {
            GameButton gameBtn = (sender as GameButton);
            new GameInfo(gameBtn.Game).Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void GamesList_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void GamesList_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GamesList_Resize(object sender, EventArgs e)
        {
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userList.ShowDialog();
        }

        public void OpenWindow(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}