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
    public partial class GamesList : Form
    {
        public static int gameWidth = 278;
        int gameHeight = 127;
        int x = 0;
        int y = 24;

        AboutWindow aboutWindow = new AboutWindow();
        UserList userList = new UserList();
        //GameInfo gameInfo;

        Game[] games;
        private int fullX;
        private ReviewList reviewList;
        private Thread updateLoop;

        /// <summary>
        /// 
        /// </summary>
        public GamesList()
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

            reviewList = new ReviewList(CurrentUser.user);

            FetchGames();
            RefreshGames();
            
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
                //RefreshGames();
            }
        }

        void Place(int x, int y, int index, Game[] g)
        {

            refreshProgressBar.Value = 50+(50 * index/g.Length);

            if (index == g.Length)
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
                gameListPanel.Controls.Add(g[index].GameName);

                g[index].GameGenre.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 43
                };
                gameListPanel.Controls.Add(g[index].GameGenre);

                g[index].GameDescription.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 60
                };
                gameListPanel.Controls.Add(g[index].GameDescription);

                g[index].ViewGameInfo.Location = new Point()
                {
                    X = x + 133,
                    Y = y + 98
                };
                g[index].ViewGameInfo.Click -= ButtonClick;
                g[index].ViewGameInfo.Click += ButtonClick;
                g[index].ViewGameInfo.Game = g[index];
                gameListPanel.Controls.Add(g[index].ViewGameInfo);

                fullX = (index + 2) * gameWidth;
                int tmpX = (this.x - 1 + (fullX % gameListPanel.Width)) / gameWidth;
                
                Place((tmpX) * gameWidth, this.y + ((fullX / gameListPanel.Width) * gameHeight),index + 1, g);
            }
        }
        void UnPlace(int index, Game[] g)
        {
            refreshProgressBar.Value =  index*50 / g.Length;
            if (index == g.Length)
            {
                return;
            }
            else
            {
                gameListPanel.Controls.Remove(g[index].GameName);
                gameListPanel.Controls.Remove(g[index].GameGenre);
                gameListPanel.Controls.Remove(g[index].GameDescription);
                gameListPanel.Controls.Remove(g[index].ViewGameInfo);
                UnPlace(index + 1, g);
            }
        }
        void RefreshGames()
        {
            refreshProgressBar.Visible = true;
            UnPlace(0, games);
            
            Place(this.x, this.y, 0, games);
            refreshProgressBar.Visible = false;
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
            RefreshGames();
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reviewList.ShowDialog();
        }

        private void GamesList_ResizeEnd(object sender, EventArgs e)
        {
            RefreshGames();
        }

        private void GamesList_ResizeBegin(object sender, EventArgs e)
        {
            RefreshGames();
        }

        private void GamesList_Resize(object sender, EventArgs e)
        {
            RefreshGames();
            this.loggedInStatusLabel.Text = CurrentUser.user.LoggedIn.ToString();
            this.userIDStatusLabel.Text = CurrentUser.userID.ToString();
            this.usernameStatusLabel.Text = CurrentUser.username;
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userList.ShowDialog();
        }

        public void FetchGames()
        {
            //List games
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Games";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            IList<Game> tmpGames = new List<Game>();
            //int i = 1;
            while (reader.Read())
            {
                // currentGameId = reader.GetString(0);
                tmpGames.Add(new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6)));

            }
            games = tmpGames.ToArray();
            reader.Close();
            conn.Close();
        }
    }
}
