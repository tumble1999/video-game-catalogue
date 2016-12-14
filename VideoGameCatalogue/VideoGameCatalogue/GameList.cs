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
    public partial class GamesList : Form
    {
        int gameWidth = 278;
        int gameHeight = 127;
        int x = 0;
        int y = 24;

        AboutWindow aboutWindow = new AboutWindow();
        GameInfo gameInfo;

        IList<Game> games = new List<Game>();
        private int fullX;

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
            
            //List games
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Games";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                games.Add(new Game(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6)));
            }
            reader.Close();
            conn.Close();


            Place(x, y, 0, games.ToArray<Game>());
        }

        private void UpdateLoop()
        {
            while (true)
            {
                accountLoggedInToolStripMenuItem.Visible = CurrentUser.user.LoggedIn;
                accountLoggedOutToolStripMenuItem.Visible = !CurrentUser.user.LoggedIn;
                loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
                userIDStatusLabel.Text = CurrentUser.userID.ToString();
                usernameStatusLabel.Text = CurrentUser.username;
            }
        }

        void Place(int x, int y, int index, Game[] g)
        {
            if(index == g.Length)
            {
                return;
            }
            else
            {
                g[index].GameName.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 12
                };
                this.Controls.Add(g[index].GameName);

                g[index].GameGenre.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 43
                };
                this.Controls.Add(g[index].GameGenre);

                g[index].GameDescription.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 60
                };
                this.Controls.Add(g[index].GameDescription);

                g[index].ViewGameInfo.Location = new Point()
                {
                    X = x + 133,
                    Y = y + 98
                };
                g[index].ViewGameInfo.Click += ButtonClick;
                this.Controls.Add(g[index].ViewGameInfo);

                fullX = (index - 1) * -gameWidth;
                Place(this.x + (fullX % this.Width), this.y + ((fullX / this.Width) * gameHeight),index + 1, g);
            }
        }

        private void ViewGameInfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            new UserLogin().Show();
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
            CurrentUser.Update();
        }

        private void aboutVideoGameCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aboutWindow.ShowDialog();
        }
        

        private void ButtonClick(object sender, EventArgs e)
        {

            //gameInfo = new GameInfo(gameTitle, gameGenre, gameDescription, gamePublisher, gamePlatform, gameReleaseDate);
            MessageBox.Show(sender.GetType().ToString());
        }
    }
}
