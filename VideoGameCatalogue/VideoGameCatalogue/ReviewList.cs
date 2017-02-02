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
    public partial class ReviewList : Form
    {
        private int reviewHeight;
        private int x;
        private int y;
        private Review[] reviews;

        public ReviewList(Game game)
        {
            InitializeComponent();

            this.Text = "Reviews - " + game.Name;
            gameTitleLabel.Text = "Reviews for " + game.Name;

        }
        public ReviewList(User user)
        {
            InitializeComponent();

            this.Text = "Reviews - " + user.Name;
            gameTitleLabel.Text = "Reviews from " + user.Name;
        }

        void Place(int x, int y, int index, Review[] r)
        {
            //refreshProgressBar.Value += (index + 1) / (g.Length * 200);
            if (index == r.Length)
            {
                return;
            }
            else
            {
                r[index].ReviewTitle.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 12
                };
                reviewListPanel.Controls.Add(r[index].ReviewTitle);

                r[index].ReviewGoodBad.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 43
                };
                reviewListPanel.Controls.Add(r[index].ReviewTitle);

                r[index].ReviewText.Location = new Point()
                {
                    X = x + 12,
                    Y = y + 60
                };
                reviewListPanel.Controls.Add(r[index].ReviewTitle);

                r[index].ViewFullReview.Location = new Point()
                {
                    X = x + 133,
                    Y = y + 98
                };
                r[index].ViewFullReview.Click += ButtonClick;
                r[index].ViewFullReview.review = r[index];
                reviewListPanel.Controls.Add(r[index].ViewFullReview);
                Place(x, this.y +  reviewHeight, index + 1, r);
            }
        }
        void UnPlace(int index, Review[] r)
        {
            //refreshProgressBar.Value += (index + 1) / (g.Length * 200);
            if (index == r.Length)
            {
                return;
            }
            else
            {
                reviewListPanel.Controls.Remove(r[index].ReviewTitle);
                reviewListPanel.Controls.Remove(r[index].ReviewGoodBad);
                reviewListPanel.Controls.Remove(r[index].ReviewText);
                reviewListPanel.Controls.Remove(r[index].ViewFullReview);
                UnPlace(index + 1, r);
            }
        }
        void RefreshReviews()
        {
            // refreshProgressBar.Visible = true;
            UnPlace(0, reviews);
            Place(this.x, this.y, 0, reviews);
            //refreshProgressBar.Visible = false;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ReviewButton reviewBtn = (sender as ReviewButton);
            //reviewInfo = new GameInfo(reviewBtn.Game);
            //reviewInfo.Show();
        }

    }
}
