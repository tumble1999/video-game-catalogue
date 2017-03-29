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
    public partial class  ChangePassword : Form
    { 
        string type;
        User user;
        public ChangePassword(ref User u)
        {
            InitializeComponent();
            user = u;
        }

        public void New(string password)
        {
            type = "New";
            this.Text = "New Password";
            labelOldPassword.Visible = textBoxOldPassword.Visible = false;
            this.Show();
            if (password == "")
            {
                //user did not type a password on registration
                textBoxNewPassword.Focus();

            }
            else
            {
                //user did enter a password on registartion
                textBoxNewPassword.Text = password;
                textBoxConfirmPassword.Focus();
            }
        }

        public void Change()
        {
            type = "Change";
            this.Text = "Change Password";
            labelOldPassword.Visible = textBoxOldPassword.Visible = true;
            this.Show();
            textBoxOldPassword.Focus();

            MessageBox.Show("Coming Soon");
            this.Hide();
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (type == "Change")
            {
                
            }
            if (type == "New")
            {
                if (textBoxConfirmPassword.Text == textBoxNewPassword.Text & textBoxConfirmPassword.Text != "")
                {
                    user.Password = textBoxNewPassword.Text;
                    user.Register();
                    if (user.Exists())
                    {
                        MessageBox.Show("Registed");
                        user.Login();
                        if (user.LoggedIn)
                        {

                            this.Hide();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("REGISTER: There was an error logging in");
                        }

                    }
                    else
                    {
                        MessageBox.Show("REGISTER: There was an error registing");
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }
    }
}
