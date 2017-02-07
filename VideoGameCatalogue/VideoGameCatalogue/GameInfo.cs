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
        private ReviewList reviewList;
        Game game;

        public GameInfo(Game g)
        {
            InitializeComponent();
            this.Text = g.Name;
            gameTitleLabel.Text = g.Name;
            gameGenreLabel.Text = g.Genre;
            gameDescriptionLabel.Text = g.Description;
            gamePublisherLabel.Text = g.Publisher;
            gamePlatformLabel.Text = g.Platform;
            gameReleaseDateLabel.Text = DateToString(g.ReleaseDate);
            gameReviewBar.Value = 10 * g.AvarageReview;
            game = g;
            reviewCountLabel.Text = g.ReviewCount + " Reviews";
            reviewList = new ReviewList(g);
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
                reviewList.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
