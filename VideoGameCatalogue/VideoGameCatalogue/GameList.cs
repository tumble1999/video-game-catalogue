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
        int y = 0;

        AboutWindow aboutWindow = new AboutWindow();
        UserList userList = new UserList();
        //GameInfo gameInfo;

        Game[] games;
        private int fullX;
        private Thread updateLoop;

        /// <summary>
        /// 
        /// </summary>
        public GamesList()
        {
            InitializeComponent();

            labelGameListTitle.Visible = false;
            this.updateLoop = new Thread(new ThreadStart(this.UpdateLoop));
            updateLoop.Start();

            //reviewList = new ReviewList(CurrentUser.user);
            FetchGames();
            
        }
        public GamesList(Company company)
        {
            InitializeComponent();

            y = 34;
            labelGameListTitle.Text = company.CompanyName;
            this.updateLoop = new Thread(new ThreadStart(this.UpdateLoop));
            updateLoop.Start();

            //reviewList = new ReviewList(CurrentUser.user);

            FetchGames(company);
            RefreshGames();
        }


        /// <summary>
        /// 
        /// </summary>
        private void UpdateLoop()
        {
            while (true)
            {
                //RefreshGames();
            }
        }

        void Place(int x, int y, int index, Game[] g)
        {

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
            UnPlace(0, games);
            
            Place(this.x, this.y, 0, games);
        }

        private void ViewGameInfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        

        private void ButtonClick(object sender, EventArgs e)
        {
            GameButton gameBtn = (sender as GameButton);
            MdiContainer.OpenWindow(new GameInfo(gameBtn.Game)).Show(); ;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshGames();
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                tmpGames.Add(new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(6), reader.GetInt32(7)));

            }
            games = tmpGames.ToArray();
            reader.Close();
            conn.Close();
        }
        public void FetchGames(Company c)
        {
            this.Text = c.CompanyName;
            //List games
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Games Where CompanyID=" + c.Id;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            IList<Game> tmpGames = new List<Game>();
            //int i = 1;
            while (reader.Read())
            {
                // currentGameId = reader.GetString(0);
                tmpGames.Add(new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(6), reader.GetInt32(7)));

            }
            games = tmpGames.ToArray();
            reader.Close();
            conn.Close();
        }

        private void labelGameListTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
