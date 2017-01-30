

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
        public Button ViewGameInfo = new Button()
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
        string title, genre, description, publisher, platform;
        DateTime releaseDate;
        //int x, y;

        IList<Reviews> games = new List<Reviews>();

        public Game(/*int x, int y,*/ string gameTitle, string gameGenre, string gameDescription, string gamePublisher, string gamePlatform, DateTime gameReleaseDate)
        {
            //this.x = x;
            ///this.y = y;

            title = gameTitle;
            genre = gameGenre;
            description = gameDescription;
            publisher = gamePublisher;
            platform = gamePlatform;
            releaseDate = gameReleaseDate;

            this.GameName.Text = title;
            this.GameGenre.Text = genre;
            this.GameDescription.Text = description;

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

    internal class Reviews
    {
    }
}
