using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public class SuperGame
    {


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
    public class Game : SuperGame
    {

        //int x, y;
        
        private string name, genre, description, platform;
        private int id = -1;
        private int companyId;
        //private int avarageReview = -1;
        //private int reviewCount = -1;
        //Review[] reviews;
        DateTime releaseDate;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Platform
        {
            get
            {
                return platform;
            }

            set
            {
                platform = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int AvarageReview
        {
            get
            {
                return Review.GetAverage(Reviews);
            }
        }

        public Review[] Reviews
        {
            get
            {
                return Review.GetReviews.Game(this); ;
            }
            
        }

        public int ReviewCount
        {
            get
            {
                return Reviews.Length;
            }
        }
        public Company Company
        {
            get
            {
                return Company.GetCompany(this.companyId);
            }
        }

        public int CompanyId
        {
            get
            {
                return companyId;
            }

            set
            {
                companyId = value;
            }
        }

        public Game(/*int x, int y,*/int gameId, string gameTitle, string gameGenre, string gameDescription, string gamePlatform, DateTime gameReleaseDate, int gameCompanyId)
        {
            //this.x = x;
            ///this.y = y;

            Id = gameId;
            Name = gameTitle;
            Genre = gameGenre;
            Description = gameDescription;
            Platform = gamePlatform;
            ReleaseDate = gameReleaseDate;
            CompanyId = gameCompanyId;
            //avarageReview = Review.GetAverage(Reviews);
            //reviewCount = Reviews.Length;


            this.GameName.Text = Name;
            this.GameGenre.Text = Genre;
            this.GameDescription.Text = Description;

            this.GameContainer.Controls.Add(this.GameName);
            this.GameContainer.Controls.Add(this.GameGenre);
            this.GameContainer.Controls.Add(this.GameDescription);
            this.GameContainer.Controls.Add(this.ViewGameInfo);

            /*GameContainer.Location = new Point()
            {
                X = GameContainer.Location.X * x,
                Y = GameContainer.Location.Y * y
            };*/
        }

        public static Game[] GetGames(Company c)
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Games WHERE GameID=" + c.Id;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            IList<Game> tmpGames = new List<Game>();
            //int i = 1;

            while (reader.Read())
            {
                tmpGames.Add(new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(6), reader.GetInt32(7)));
            }
            reader.Close();
            conn.Close();
            return tmpGames.ToArray();
        }

        internal void Update()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("UPDATE Games SET Username = @Username, [Password] = @Password WHERE GameID = @id");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@id", Id);

                //MessageBox.Show(cmd.CommandText);

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

        internal void Register()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("INSERT into Users (Username, [Password]) Values(@Username, @Password) ");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                //MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Data Added");
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

            Update();


        }

    }
    public class GameButton : Button
    {
        public Game Game { get; internal set; }// added game property to Button class
    }
    
}
