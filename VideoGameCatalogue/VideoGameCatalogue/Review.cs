﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public class SuperReview
    {
        private static string owner;

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public Label GameName = new Label()
        {
            Text = "Gamename",
            Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            AutoSize = true,
            MaximumSize = new Size()
            {
                Width = GamesList.gameWidth - 13,
                Height = 0
            },
            Location = new Point()
            {
                X = 13,
                Y = 13
            }
        };
        public Label GameGenre = new Label()
        {
            Text = "GameGenre",
            AutoSize = true,
            Location = new Point()
            {
                X = 13,
                Y = 13
            }
        };
        public Label GameDescription = new Label()
        {
            Text = "GameDescription",
            Width = 244,
            Height = 35,
            AutoEllipsis = true,
            Location = new Point()
            {
                X = 12,
                Y = 1
            }
        };
        public GameButton ViewGameInfo = new GameButton()
        {
            Width = 75,
            Height = 23,
            Text = "Game Info",

            Location = new Point()
            {
                X = 75,
                Y = 23
            }
        };
        public Panel GameContainer = new Panel()
        {
            Width = 278,
            Height = 127,
            Location = new Point()
            {
                X = 0,
                Y = 27,
            },
            Enabled = true
        };
    }


    public class Review : SuperReview
    {
        private int iD, userID, gameID, rating;
        private string text;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public int GameID
        {
            get
            {
                return gameID;
            }

            set
            {
                gameID = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }
        public Review(int reviewId, int reviewUserId, int reviewGameId, string reviewText, int reviewRating)
        {
            iD = reviewId;
            userID = reviewUserId;
            gameID = reviewGameId;
            text = reviewText;
            rating = reviewRating;

        }

        public static class GetReviews
        {
            public static Review[] Game(int gameId)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                ///add only game ID
                while (reader.Read())
                {
                    if (reader.GetInt32(2) == gameId)
                    {
                        // currentGameId = reader.GetString(0);
                        tmpReviews.Add(new Review(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4)));
                    }
                }
                reader.Close();
                conn.Close();
                return tmpReviews.ToArray();
            }

            public static Review[] User(int userId)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                ///add only game ID
                while (reader.Read())
                {
                    if (reader.GetInt32(1) == userId)
                    {
                        // currentGameId = reader.GetString(0);
                        tmpReviews.Add(new Review(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4)));
                    }
                }

                reader.Close();
                conn.Close();
                return tmpReviews.ToArray();
            }
        }
        public static int GetAverage(Review[] rArray)
        {
            int a = 0;
            foreach (Review r in rArray)
            {
                a += r.Rating;
            }

            if (rArray.Length == 0)
            {
                return a;
            }
            else
            {
                return a / rArray.Length;
            }
        }
    }
}
