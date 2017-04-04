using System;
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
        
        UserList userList = new UserList();
        //ReviewList reviewlist;

        //private ReviewList reviewList;
        private Thread updateLoop;
        public static MdiContainer mdiContainer;

        /// <summary>
        /// 
        /// </summary>
        public MdiContainer()
        {
            mdiContainer = this;
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
            OpenWindow(new GamesList() {
                ControlBox = false
            }).Show();
           
            
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
            new UserLogin().ShowDialog();
            CurrentUser.Update();
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserLogin().ShowDialog();
            CurrentUser.Update();
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.user.Logout();
            CurrentUser.Update();
            RefreshStatus();
        }

        private void aboutVideoGameCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AboutWindow().ShowDialog();
        }
        

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            OpenWindow(new ReviewList(CurrentUser.user)).Show();
        }

        private void GamesList_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void GamesList_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GamesList_Resize(object sender, EventArgs e)
        {
            CurrentUser.Update();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiContainer.OpenWindow(new UserList()).Show();
        }

        public static Form OpenWindow(Form form)
        {
            form.MdiParent = mdiContainer;
            return form;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword tmp = new ChangePassword(ref CurrentUser.user);
            tmp.Change();
            tmp.ShowDialog();
            CurrentUser.Update();
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;

        }
        public void RefreshStatus()
        {
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void companyManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWindow(new CompanyManager(ref CurrentUser.user)).Show();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(this.SelectedText);

            //this.SelectedText = string.Empty;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(this.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string xx = Clipboard.GetText();

           //this.Text = this.Text.Insert(this.SelectionStart, xx);
        }
    }
}
