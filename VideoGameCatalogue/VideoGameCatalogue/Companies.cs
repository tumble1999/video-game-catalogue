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
        public static Companies companies;
        public Companies(ref User u)
        {
            companies = this;
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshCompanies();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new NewCompany(user).ShowDialog();
        }

        private void listBoxCompanies_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCompanies.SelectedItem != null)
            {
                new NewCompany(user.Companies[listBoxCompanies.SelectedIndex]).Show();
            }
        }
        public void RefreshCompanies()
        {
            listBoxCompanies.Items.Clear();
            foreach (var company in user.Companies)
            {
                listBoxCompanies.Items.Add(company.CompanyName);
            }
        }
    }
}
