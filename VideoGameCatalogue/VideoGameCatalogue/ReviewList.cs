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
        public ReviewList(Game g)
        {
            InitializeComponent();

            this.Text = "Reviews for: " + g.Title;

            foreach (Review review in g.Reviews)
            {

            }
        }
        /*
        public ReviewList(Review[] reviews, User u)
        {

        }*/
    }
}
