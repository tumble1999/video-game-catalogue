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
        //private List<Review> tmpList;

        public NewReview(Game g, User u)
        {
            InitializeComponent();
            this.g = g;
            this.u = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGood_Click(object sender, EventArgs e)
        {
            new Review(g, u, reviewTextTextBox.Text, 10);
        }

        private void buttonBad_Click(object sender, EventArgs e)
        {
            new Review(g, u, reviewTextTextBox.Text, 1);
        }
    }
}
