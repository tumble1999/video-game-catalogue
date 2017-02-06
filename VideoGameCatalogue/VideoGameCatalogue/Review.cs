using System;
using System.Collections.Generic;
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
                X = 9,
                Y = 3
            }
        };
        public Label ReviewGoodBad = new Label()
        {
            Text = "ReviewGoodBad",
            AutoSize = true,
            Location = new Point()
            {
                X = 200,
                Y = 18
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
                X = 15,
                Y = 34
            }
        };
        public ReviewButton ViewFullReview = new ReviewButton()
        {
            Width = 75,
            Height = 23,
            Text = "Full Review",

            Location = new Point()
            {
                X = 75,
                Y = 23
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
        private string reviewUserId;
        private string gameName, userName;

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

        public string ReviewUserId
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

        public Review(int reviewId, string reviewGameName, string reviewUserName, string reviewText, int reviewRating)
        {
            ID = reviewId;
            GameName = reviewGameName;
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

        public static class GetReviews
        {
            public static Review[] Game(int gameId, string gameName)
            {

                try
                {
                    OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                    string sql = "SELECT * FROM Reviews WHERE GameID=" + gameId;
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    conn.Open();

                    OleDbDataReader reader;
                    reader = cmd.ExecuteReader();

                    IList<Review> tmpReviews = new List<Review>();
                    //int i = 1;

                    string tmpName = "";
                    ///add only game ID
                    while (reader.Read())
                    {


                        OleDbConnection connUser = new OleDbConnection(new Settings().VGCConnectionString);
                        string sqlUser = "SELECT * FROM Users";
                        OleDbCommand cmdUser = new OleDbCommand(sqlUser, connUser);
                        connUser.Open();
                        OleDbDataReader readerUser;
                        readerUser = cmdUser.ExecuteReader();
                        while (readerUser.Read())
                        {
                            tmpName = readerUser.GetString(1);
                        }
                        readerUser.Close();
                        connUser.Close();


                        // currentGameId = reader.GetString(0);
                        tmpReviews.Add(new Review(reader.GetInt32(0), gameName, tmpName, reader.GetString(3), reader.GetInt32(4))
                        {
                            Owner = "Game"
                        });
                    }
                    reader.Close();
                    conn.Close();
                    return tmpReviews.ToArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                    throw;
                }
            }

            public static Review[] User(int userId, string userName)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews WHERE UserID=" + userId;
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                string tmpName = "";
                ///add only game ID
                while (reader.Read())
                {


                    OleDbConnection connGame = new OleDbConnection(new Settings().VGCConnectionString);
                    string sqlGame = "SELECT * FROM Games";
                    OleDbCommand cmdUser = new OleDbCommand(sqlGame, connGame);
                    connGame.Open();
                    OleDbDataReader readerGame;
                    readerGame = cmdUser.ExecuteReader();
                    while (readerGame.Read())
                    {
                        tmpName = readerGame.GetString(1);
                    }
                    readerGame.Close();
                    connGame.Close();


                    // currentGameId = reader.GetString(0);
                    tmpReviews.Add(new Review(reader.GetInt32(0), tmpName, userName, reader.GetString(3), reader.GetInt32(4))
                    {
                        Owner = "User"
                    });
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
    public class ReviewButton : Button
    {
        public Review review { get; internal set; }// added review property to Button class
    }
}
