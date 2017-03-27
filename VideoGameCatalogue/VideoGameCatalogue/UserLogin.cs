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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "")
            {
                if (passwordTextBox.Text != "")
                {
                    CurrentUser.user = new User(usernameTextBox.Text, passwordTextBox.Text);
                    if (CurrentUser.user.Exists())
                    {
                        CurrentUser.user.Login();
                        if (CurrentUser.user.LoggedIn)
                        {
                            MessageBox.Show("Logged in");

                            this.Hide();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("LOGIN: There was an errror logging in");
                        }
                    }
                    else
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "LOGIN: Username or Password Incorect";
                    }
                    CurrentUser.Update();
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "LOGIN: Password cannot be blank";
                }
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "LOGIN: Username cannot be blank";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "")
            {
                if (passwordTextBox.Text != "")
                {
                    CurrentUser.user = new User(usernameTextBox.Text, passwordTextBox.Text);
                    if (!CurrentUser.user.Exists())
                    {
                        CurrentUser.user.Register();
                        if (CurrentUser.user.Exists())
                        {
                            MessageBox.Show("Registed");
                            CurrentUser.user.Login();
                            if (CurrentUser.user.LoggedIn)
                            {

                                this.Hide();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("REGISTER: There was an errror logging in");
                            }

                        }
                        else
                        {
                            MessageBox.Show("REGISTER: There was an errror registing");
                        }
                    }
                    else
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "REGISTER: User Exists";
                    }
                    CurrentUser.Update();
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "REGISTER: Password cannot be blank";
                }
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "REGISTER: Username cannot be blank";
            }
        }
    }
}
