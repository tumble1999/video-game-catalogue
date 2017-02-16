using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameCatalogue
{
    public partial class GameInfo : Form
    {
        //private ReviewList reviewList;
        Game game;

        public GameInfo(Game g)
        {
            InitializeComponent();

            game = g;
            RefreshGameInfo();

            
        }

        public static string DateToString(DateTime date)
        {
            string output = date.ToShortDateString();

            //Insert If statements to say number of days ago
            //MessageBox.Show("DateTime.Now.Subtract(date).Days.ToString(): " + DateTime.Now.Subtract(date).Days.ToString());
            int days = DateTime.Now.Subtract(date).Days;
            int weeks = days / 7;
            //MessageBox.Show("Weeks: " + weeks.ToString() + ", Days: " + days.ToString());

            if (1 < weeks & weeks<10)
            {
                output = weeks + " weeks ago";
            }
            else if (weeks == 1)
            {
                output = "Last week";
            }
            else if (1 < days & weeks < 1)
            {
                output = days + " days ago";
            }
            else if (days == 1)
            {
                output = "Yesterday";
            }
            else if (days == 0)
            {
                output = "Today";
            } else
            {
                output = date.ToShortDateString();
            }

            return output;
        }

        private void buttonAllReviews_Click(object sender, EventArgs e)
        {
            
            try
            {
                new ReviewList(game, this).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void RefreshGameInfo()
        {
            this.Text = game.Name;
            gameTitleLabel.Text = game.Name;
            gameGenreLabel.Text = game.Genre;
            gameDescriptionLabel.Text = game.Description;
            gamePublisherLabel.Text = game.Publisher;
            gamePlatformLabel.Text = game.Platform;
            gameReleaseDateLabel.Text = DateToString(game.ReleaseDate);
            gameReviewBar.Value = 10 * game.AvarageReview;
            reviewCountLabel.Text = game.ReviewCount + " Reviews";
        }
    }
}
