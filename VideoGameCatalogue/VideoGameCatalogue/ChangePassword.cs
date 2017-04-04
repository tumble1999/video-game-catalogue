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
        public User user;
        string newPassword;
        public ChangePassword(ref User u)
        {
            InitializeComponent();
            user = u;
        }

        public ChangePassword New(string password)
        {
            type = "New";
            newPassword = password;
            this.Text = "New Password";
            return this;
        }

        public ChangePassword Change()
        {
            type = "Change";

            /*MessageBox.Show("Coming Soon");
            this.Hide();
            this.Close();*/
            return this;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (type == "Change")
            {
                if(textBoxOldPassword.Text == user.Password & textBoxConfirmPassword.Text == textBoxNewPassword.Text & textBoxConfirmPassword.Text != "")
                {
                    user.Password = textBoxNewPassword.Text;
                    user.Update();
                    if(user.Password == textBoxNewPassword.Text)
                    {

                        this.Hide();
                        this.Close();
                    } else
                    {
                        MessageBox.Show("There was an error somewhere!");
                    }
                }
                else
                {
                    MessageBox.Show("Either Textboxes are empty \n old password  is wrong \n or new passwords dont match.");
                }
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
                        this.Hide();
                        this.Close();
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (type == "Change")
            {
                this.Text = "Change Password";
                labelOldPassword.Visible = textBoxOldPassword.Visible = true;
                textBoxOldPassword.Focus();
            }
            if (type == "New")
            {
                labelOldPassword.Visible = textBoxOldPassword.Visible = false;
                if (newPassword == "")
                {
                    //user did not type a password on registration
                    textBoxNewPassword.Focus();

                }
                else
                {
                    //user did enter a password on registartion
                    textBoxNewPassword.Text = newPassword;
                    textBoxConfirmPassword.Focus();
                }
            }
        }
    }
}
