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
    public partial class Companies : Form
    {
        User user;
        public Companies(ref User u)
        {
            user = u;
            InitializeComponent();
            foreach (var company in u.Companies)
            {
                listBoxCompanies.Items.Add(company.CompanyName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxCompanies_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listBoxCompanies.SelectedItems.Count >= 1;
        }

        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Companies_Load(object sender, EventArgs e)
        {

        }
    }
}
