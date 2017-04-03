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
    public partial class NewCompany : Form
    {
        private User user;
        private Company company;
        private String t;

        public NewCompany(User u)
        {
            InitializeComponent();
            this.user = u;
            this.t = "new";
        }
        public NewCompany(Company c)
        {
            InitializeComponent();
            this.company = c;
            this.t = "edit";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "") {
                if (t == "new")
                {
                    new Company(textBoxName.Text, user.Id).New();
                }
                else if (t == "edit")
                {
                    company.CompanyName = textBoxName.Text;
                    company.Update();
                }
            } else
            {
                MessageBox.Show(labelName.Text + "is empty.");
            }
        }
    }
}
