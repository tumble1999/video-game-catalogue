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

                            CurrentUser.Update();
                            MdiContainer.mdiContainer.RefreshStatus();
                            this.Hide();
                            this.Close();

                        }
                        else
                        {
                            errorLabel.Visible = true;
                            errorLabel.Text = "LOGIN: There was an errror logging in";
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
                CurrentUser.user = new User(usernameTextBox.Text, "");

                if (!CurrentUser.user.Exists())
                {
                    ChangePassword tmp =  new ChangePassword(ref CurrentUser.user);
                    tmp.New(passwordTextBox.Text);

                    tmp.ShowDialog();
                    CurrentUser.user.Login();
                    if (CurrentUser.user.LoggedIn)
                    {
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "REGISTER: There was an error logging in";
                    }
                    if (CurrentUser.user.LoggedIn)
                    {
                        CurrentUser.Update();
                        MdiContainer.mdiContainer.RefreshStatus();
                        this.Hide();
                        this.Close();
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
                errorLabel.Text = "REGISTER: Username cannot be blank";
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}
