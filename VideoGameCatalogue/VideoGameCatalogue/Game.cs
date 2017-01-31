

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue;

namespace VideoGameCatalogue
{
    public class SuperGame
    {


        public Label GameName = new Label()
        {
            Text = "Gamename",
            Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            AutoSize = true,
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
        
        private string title;
        private string genre;
        private string description;
        private string publisher;
        private string platform;
        private int avarageReview;
        Review[] reviews;

        DateTime releaseDate;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
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

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
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

        public Game(/*int x, int y,*/ string gameTitle, string gameGenre, string gameDescription, string gamePublisher, string gamePlatform, DateTime gameReleaseDate)
        {
            //this.x = x;
            ///this.y = y;

            Title = gameTitle;
            Genre = gameGenre;
            Description = gameDescription;
            Publisher = gamePublisher;
            Platform = gamePlatform;
            ReleaseDate = gameReleaseDate;


            this.GameName.Text = Title;
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

    }

    public class SuperReview
    {

    }

    public class Review : SuperReview
    {
        private int userID, gameID, rating;
        private string reviewText;

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

        public string ReviewText
        {
            get
            {
                return reviewText;
            }

            set
            {
                reviewText = value;
            }
        }
    }

    public class GameButton : Button
    {
        public Game Game { get; internal set; }// added game property to Button class
    }



}
