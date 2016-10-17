using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VideoGameCatalogue
{
    public partial class GamesList : Form
    {
        AboutWindow aboutWindow = new AboutWindow();
        public GamesList()
        {
            InitializeComponent();
            Thread updateLoop = new Thread(new ThreadStart(UpdateLoop));
            CurrentUser.Update();
            accountLoggedInToolStripMenuItem.Visible = CurrentUser.user.LoggedIn;
            accountLoggedOutToolStripMenuItem.Visible = !CurrentUser.user.LoggedIn;
            statusBar.Visible = statusBarToolStripMenuItem.Checked;
            loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            userIDStatusLabel.Text = CurrentUser.userID.ToString();
            usernameStatusLabel.Text = CurrentUser.username;
            updateLoop.Start();

        }

        private void UpdateLoop()
        {
            while (true)
            {
                CurrentUser.Update();
                accountLoggedInToolStripMenuItem.Visible = CurrentUser.user.LoggedIn;
                accountLoggedOutToolStripMenuItem.Visible = !CurrentUser.user.LoggedIn;
                loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
                userIDStatusLabel.Text = CurrentUser.userID.ToString();
                usernameStatusLabel.Text = CurrentUser.username;
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.user.Login();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.user.Logout();
        }

        private void aboutVideoGameCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aboutWindow.Show();
        }
    }
}
