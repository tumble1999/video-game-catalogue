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
        int width = 0;
        int height = 10;
        int fullX = 0;
        int x = 0;
        int y = 24;

        AboutWindow aboutWindow = new AboutWindow();
        GameItem gameItem = new GameItem();
        GameInfo gameInfo;
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
                fullX = i * width;
                x += (fullX % this.Width);
                y += (fullX / this.Width) * height;
                //reader.GetInt32(0); -> id
                //reader.GetString(1); -> name
                //PlaceGame(x, y, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                gameItem.GameName.Text = reader.GetString(1);
                gameItem.GameName.Location = new Point()
                {
                    X = x + 21,
                    Y = y + 11
                };

                gameItem.GameGenre.Text = reader.GetString(2);
                gameItem.GameGenre.Location = new Point()
                {
                    X = x + 24,
                    Y = y + 43
                };

                gameItem.GameDescription.Text = reader.GetString(3);
                gameItem.GameDescription.Location = new Point()
                {
                    X = x + 27,
                    Y = y + 60
                };

                //gameItem.ViewGameInfo.Click += ButtonClick(gameTitle,gameGenre,gameDescription,gamePublisher,gamePlatform,gameReleaseDate);
                //new EventHandler(ButtonClick(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                gameItem.ViewGameInfo.Click += new System.EventHandler(this.ButtonClick);
                gameItem.ViewGameInfo.Location = new Point()
                {
                    X = x + 33,
                    Y = y + 98
                };


                this.Controls.Add(gameItem.GameName);
                this.Controls.Add(gameItem.GameGenre);
                this.Controls.Add(gameItem.ViewGameInfo);
                this.Controls.Add(gameItem.GameDescription);

                //gameInfo = new GameInfo(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                //gameInfo.ShowDialog();


                //gameInfo = new GameInfo(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                //gameInfo.ShowDialog();
                //MessageBox.Show(reader.GetString(1));
                i++;
            }
            reader.Close();
            conn.Close();
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
            gameInfo.ShowDialog();
        }
    }
}
