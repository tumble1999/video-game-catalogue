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
        private int reviewHeight = 127;
        private int x = 6;
        private int y = 3;
        private Review[] reviews;
        private FullReview fullReview;
        private NewReview newReview;
        private Game game;
        private User user;

        public ReviewList(Game game)
        {
            this.game = game;
            InitializeComponent();

            buttonNewReview.Show();
            this.Text = "Reviews - " + game.Name;
            gameTitleLabel.Text = "Reviews for " + game.Name;
            reviews = game.Reviews;
            RefreshReviews();
            

        }
        public ReviewList(User user)
        {
            this.user = user;
            InitializeComponent();

            buttonNewReview.Hide();
            this.Text = "Reviews - " + user.Name;
            gameTitleLabel.Text = "Reviews from " + user.Name;
            reviews = user.Reviews;
            RefreshReviews();
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
                    X = x + this.reviewTitle.Location.X,
                    Y = y + this.reviewTitle.Location.Y
                };
                reviewListPanel.Controls.Add(r[index].ReviewTitle);

                r[index].ReviewGoodBad.Location = new Point()
                {
                    X = x + this.reviewGoodBadText.Location.X,
                    Y = y + this.reviewGoodBadText.Location.Y
                };
                reviewListPanel.Controls.Add(r[index].ReviewGoodBad);

                r[index].ReviewText.Location = new Point()
                {
                    X = x + this.reviewTextLabel.Location.X,
                    Y = y + this.reviewTextLabel.Location.Y
                };
                reviewListPanel.Controls.Add(r[index].ReviewText);

                r[index].ViewFullReview.Location = new Point()
                {
                    X = x + this.viewReviewButton.Location.X,
                    Y = y + this.viewReviewButton.Location.Y
                };
                r[index].ViewFullReview.Click += ButtonClick;
                r[index].ViewFullReview.review = r[index];
                reviewListPanel.Controls.Add(r[index].ViewFullReview);
                Place(x, this.y + reviewHeight, index + 1, r);
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
            fullReview = new FullReview(reviewBtn.review);
            fullReview.Show();
        }

        private void ReviewList_Resize(object sender, EventArgs e)
        {
            //RefreshReviews();
        }

        private void buttonNewReview_Click(object sender, EventArgs e)
        {
            newReview = new NewReview(game, CurrentUser.user);
            newReview.ShowDialog();
        }
    }
}
