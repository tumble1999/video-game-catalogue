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
        ReviewOwner reviewsOwner;

        public ReviewList(Game game)
        {
            InitializeComponent();

            reviewsOwner = game;

            Go();
        }
        public ReviewList(User user)
        {
            InitializeComponent();

            reviewsOwner = user;
        }
        private void Go()
        {
            this.Text = "Reviews for: " + reviewsOwner.Name;

            foreach (Review review in reviewsOwner.ga )
            {

            }
        }
    }
}
