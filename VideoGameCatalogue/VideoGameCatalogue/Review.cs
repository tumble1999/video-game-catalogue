using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public class SuperReview
    {
        

        public Label ReviewTitle = new Label()
        {
            Text = "ReviewTitle",
            Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            AutoSize = true,
            MaximumSize = new Size()
            {
                Width = GamesList.gameWidth - 13,
                Height = 0
            },
            Location = new Point()
            {
                X = 3,
                Y = 3
            }
        };
        public Label ReviewGoodBad = new Label()
        {
            Text = "ReviewGoodBad",
            AutoSize = true,
            Location = new Point()
            {
                X = 3,
                Y = 34
            }
        };
        public Label ReviewText = new Label()
        {
            Text = "ReviewText",
            Width = 244,
            Height = 35,
            AutoEllipsis = true,
            Location = new Point()
            {
                X = 3,
                Y = 47
            }
        };
        public ReviewButton ViewFullReview = new ReviewButton()
        {
            Width = 75,
            Height = 23,
            Text = "Full Review",

            Location = new Point()
            {
                X = 628,
                Y = 101
            }
        };
        public Panel ReviewContainer = new Panel()
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
        private int iD, rating;

        private string text;
        private string goodBad;
        private int reviewUserId, reviewGameId;
        private string gameName, userName;
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

        public string TextContent
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

        public string GoodBad
        {
            get
            {
                return goodBad;
            }

            set
            {
                goodBad = value;
            }
        }

        public int ReviewUserId
        {
            get
            {
                return reviewUserId;
            }

            set
            {
                reviewUserId = value;
            }
        }

        public string GameName
        {
            get
            {
                return gameName;
            }

            set
            {
                gameName = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int ReviewGameId
        {
            get
            {
                return reviewGameId;
            }

            set
            {
                reviewGameId = value;
            }
        }

        public Review(int reviewId, Game g, User u, string reviewText, int reviewRating)
        {
            ID = reviewId;
            GameName = g.Name;
            UserName = u.Name;
            ReviewUserId = u.Id;
            reviewGameId = g.Id;
            TextContent = reviewText;
            Rating = reviewRating;
            
            if (Rating >= 5)
            {
                GoodBad = "Good";
            } else if (rating < 5) {
                GoodBad = "Bad";
            } else {
                GoodBad = "I don't know.";
            }
            
            this.ReviewGoodBad.Text = GoodBad;
            this.ReviewText.Text = TextContent;

        }
        public Review(int reviewId, Game g, User u, string reviewText, int reviewRating, string reviewOwner) {
            ID = reviewId;
            GameName = g.Name;
            UserName = u.Username;
            ReviewUserId = u.Id;
            reviewGameId = g.Id;
            TextContent = reviewText;
            Rating = reviewRating;
            Owner = reviewOwner;
            

            if (Rating >= 5)
            {
                GoodBad = "Good";
            }
            else if (rating < 5)
            {
                GoodBad = "Bad";
            }
            else
            {
                GoodBad = "I don't know.";
            }

            this.ReviewGoodBad.Text = GoodBad;
            this.ReviewText.Text = TextContent;
            
            if (Owner == "Game")
            {
                this.ReviewTitle.Text = u.Name;
            }
            else if (Owner == "User")
            {
                this.ReviewTitle.Text = g.Name;
            }


        }

        public Review(Game g, User u, string reviewText, int reviewRating)
        {
            GameName = g.Name;
            UserName = u.Username;
            ReviewUserId = u.Id;
            reviewGameId = g.Id;
            TextContent = reviewText;
            Rating = reviewRating;


            if (Rating >= 5)
            {
                GoodBad = "Good";
            }
            else if (rating < 5)
            {
                GoodBad = "Bad";
            }
            else
            {
                GoodBad = "I don't know.";
            }

            this.ReviewGoodBad.Text = GoodBad;
            this.ReviewText.Text = TextContent;

            if (Owner == "Game")
            {
                this.ReviewTitle.Text = u.Name;
            }
            else if (Owner == "User")
            {
                this.ReviewTitle.Text = g.Name;
            }
            this.SaveToDatabase();


        }

        public static class GetReviews
        {
            public static Review[] Game(Game g)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews WHERE GameID=" + g.Id;
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                User tmpUser = VideoGameCatalogue.User.empty;
                ///add only game ID
                while (reader.Read())
                {


                    OleDbConnection connUser = new OleDbConnection(new Settings().VGCConnectionString);
                    string sqlUser = "SELECT * FROM Users WHERE UserID=" + reader.GetInt32(1);
                    OleDbCommand cmdUser = new OleDbCommand(sqlUser, connUser);
                    connUser.Open();
                    OleDbDataReader readerUser;
                    readerUser = cmdUser.ExecuteReader();
                    while (readerUser.Read())
                    {
                       tmpUser = new User(readerUser.GetInt32(0), readerUser.GetString(1), readerUser.GetString(2));
                    }
                    readerUser.Close();
                    connUser.Close();


                    // currentGameId = reader.GetString(0);
                    tmpReviews.Add(new Review(reader.GetInt32(0), g, tmpUser, reader.GetString(3), reader.GetInt32(4), "Game"));
                }
                reader.Close();
                conn.Close();
                return tmpReviews.ToArray();
            }

            public static Review[] User(User u)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews WHERE UserID=" + u.Id;
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                Game tmpGame = null;
                ///add only game ID
                while (reader.Read())
                {


                    OleDbConnection connUser = new OleDbConnection(new Settings().VGCConnectionString);
                    string sqlUser = "SELECT * FROM Games";
                    OleDbCommand cmdUser = new OleDbCommand(sqlUser, connUser);
                    connUser.Open();
                    OleDbDataReader readerGame;
                    readerGame = cmdUser.ExecuteReader();
                    while (readerGame.Read())
                    {
                        tmpGame = new Game(readerGame.GetInt32(0), readerGame.GetString(1), readerGame.GetString(2), readerGame.GetString(3), readerGame.GetString(4), readerGame.GetString(5), readerGame.GetDateTime(6));
                    }
                    readerGame.Close();
                    connUser.Close();


                    // currentGameId = reader.GetString(0);
                    tmpReviews.Add(new Review(reader.GetInt32(0), tmpGame, u, reader.GetString(3), reader.GetInt32(4), "Game"));
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

        internal void SaveToDatabase()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("INSERT into Review (UserID, GameID, ReviewText, Raiting) Values(@UserID, @GameID, @ReviewText, @Raiting) ");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@UserID", ReviewUserId);
                cmd.Parameters.AddWithValue("@GameID", ReviewGameId);
                cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("@Raiting", Rating);

                MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Connection Failed");
            }

            cmd = new OleDbCommand("UPDATE Reviews SET UserID = @UserID, GameID = @GameID, ReviewText = @ReviewText, Raiting = @Raiting WHERE ReviewID = @id");
            cmd.Connection = conn;

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@UserID", ReviewUserId);
                cmd.Parameters.AddWithValue("@GameID", ReviewGameId);
                cmd.Parameters.AddWithValue("@ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("@Raiting", Rating);
                cmd.Parameters.AddWithValue("@id", ID);

                MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();
                }
                catch (OleDbException e)
                {
                    MessageBox.Show("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Connection Failed");
            }


        }

    }
    
    public class ReviewButton : Button
    {
        public Review review { get; internal set; }// added review property to Button class
    }
}
