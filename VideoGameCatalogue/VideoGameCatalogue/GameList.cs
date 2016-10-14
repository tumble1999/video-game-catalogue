using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VideoGameCatalogue
{
    public partial class GamesList : Form
    {
        public GamesList()
        {
            CurrentUser.Update();
            InitializeComponent();
            statusBar.Visible = statusBarToolStripMenuItem.Checked;
            loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            userIDStatusLabel.Text = CurrentUser.userID.ToString(); ;
            usernameStatusLabel.Text = CurrentUser.username;         

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
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
