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
    public partial class FullReview : Form
    {
        public FullReview(Review r)
        {
            InitializeComponent();

            reviewTitle.Text = "Review of " + r.GameName + " by " + r.UserName;
            reviewGoodBadText.Text = r.GoodBad;
            reviewTextLabel.Text = r.TextContent;

        }
    }
}
