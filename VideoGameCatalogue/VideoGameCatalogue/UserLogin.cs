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
            CurrentUser.user = new User(usernameTextBox.Text, passwordTextBox.Text);
            if (CurrentUser.user.Exists())
            {
                CurrentUser.user.Login();
                if(CurrentUser.user.LoggedIn)
                {
                    MessageBox.Show("Logged in");
                    
                }
                else
                {
                    MessageBox.Show("There was an errror logging in");
                }
                this.Hide();
                this.Close();
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Username or Password Incorect";
            }
            CurrentUser.Update();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            CurrentUser.user = new User(usernameTextBox.Text, passwordTextBox.Text);
            if (!CurrentUser.user.Exists())
            {
                CurrentUser.user.Register();
                if (CurrentUser.user.Exists())
                {
                    MessageBox.Show("Registed");
                }
                else
                {
                    MessageBox.Show("There was an errror registing");
                }
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "User Exists";
            }
            CurrentUser.Update();
        }
    }
}
