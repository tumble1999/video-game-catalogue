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
    }
}
