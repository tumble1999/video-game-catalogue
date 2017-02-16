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
    public partial class NewReview : Form
    {
        private Game g;
        private User u;
        private Review review;
        public ReviewList reviewList;

        //private List<Review> tmpList;

        public NewReview(Game g, User u, ReviewList reviewList)
        {
            InitializeComponent();
            this.g = g;
            this.u = u;
            this.reviewList = reviewList;
            //MessageBox.Show("User: " + u.Name + "\nGame: " + g.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGood_Click(object sender, EventArgs e)
        {
            review = new Review(g, u, reviewTextTextBox.Text, 10);
            review.SaveToDatabase();
            reviewList.RefreshReviews();
            this.Close();
        }

        private void buttonBad_Click(object sender, EventArgs e)
        {
            review = new Review(g, u, reviewTextTextBox.Text, 1);
            review.SaveToDatabase();
            reviewList.RefreshReviews();

            this.Close();
        }
    }
}
