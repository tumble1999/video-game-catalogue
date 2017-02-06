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

        public ReviewList(Game game)
        {
            InitializeComponent();

            this.Text = "Reviews - " + game.Name;
            gameTitleLabel.Text = "Reviews for " + game.Name;
            reviews = game.Reviews;
            RefreshReviews();

        }
        public ReviewList(User user)
        {
            InitializeComponent();

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
                    X = x + 9,
                    Y = y + 3
                };
                if(r[index].Owner == "Game")
                {
                    r[index].ReviewTitle.Text = r[index].UserName;
                } else if (r[index].Owner == "User")
                {
                    r[index].ReviewTitle.Text = r[index].GameName;
                }
                reviewListPanel.Controls.Add(r[index].ReviewTitle);

                r[index].ReviewGoodBad.Location = new Point()
                {
                    X = x + 160,
                    Y = y + 30
                };
                reviewListPanel.Controls.Add(r[index].ReviewGoodBad);

                r[index].ReviewText.Location = new Point()
                {
                    X = x + 15,
                    Y = y + 34
                };
                reviewListPanel.Controls.Add(r[index].ReviewText);

                r[index].ViewFullReview.Location = new Point()
                {
                    X = x + 622,
                    Y = y + 101
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
            //reviewInfo = new GameInfo(reviewBtn.Game);
            //reviewInfo.Show();
        }

    }
}
