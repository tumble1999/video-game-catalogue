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
    public partial class ChangePassword : Form
    {
        User u;
        public ChangePassword(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        public void New(string password)
        {
            labelOldPassword.Visible = textBoxOldPassword.Visible = false;
            if(password == "")
            {
                //user did not type a password on registration

            }
            else
            {
                //user did enter a password on registartion
            }
            this.Show();
        }

        public void Change()
        {
            labelOldPassword.Visible = textBoxOldPassword.Visible = true;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
