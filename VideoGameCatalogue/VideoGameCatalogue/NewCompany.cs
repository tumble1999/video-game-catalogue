﻿using System;
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
            this.Text = "New Company";
        }
        public NewCompany(Company c)
        {
            InitializeComponent();
            this.company = c;
            this.t = "edit";
            textBoxName.Text = company.CompanyName;
            this.Text = "Rename " + company.CompanyName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "") {
                if (t == "new")
                {
                    Company c = new Company(textBoxName.Text, user.Id);
                    if (!c.Exists())
                    {
                        c.New();

                        Companies.companies.RefreshCompanies();
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Company Exists");
                    }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void NewCompany_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }
    }
}
