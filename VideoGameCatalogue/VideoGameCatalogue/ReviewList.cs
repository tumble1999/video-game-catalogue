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

        public ReviewList(Game game)
        {
            InitializeComponent();

            this.Text = "Reviews - " + game.Name;
            gameTitleLabel.Text = "Reviews for " + game.Name;

            foreach (Review review in game.Reviews )
            {

            }
        }
        public ReviewList(User user)
        {
            InitializeComponent();

            this.Text = "Reviews - " + user.Name;
            gameTitleLabel.Text = "Reviews from " + user.Name;

            foreach (Review review in user.Reviews)
            {

            }
        }
    }
}
