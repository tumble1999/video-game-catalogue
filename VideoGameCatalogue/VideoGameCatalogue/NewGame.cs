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
    public partial class NewGame : Form
    {
        string t;
        User user;
        Game game;
        public NewGame(User u)
        {
            InitializeComponent();
            this.user = u;
            this.t = "new";
            this.Text = "New Game";
            foreach (Company company in u.Companies)
            {
                comboBoxCompany.Items.Add(company.CompanyName);
            }
        }
        public NewGame(Game g, User u)
        {
            InitializeComponent();
            this.game = g;
            this.user = u;

            foreach (Company company in u.Companies)
            {
                comboBoxCompany.Items.Add(company.CompanyName);
            }

            textBoxDescription.Text = g.Description;
            textBoxGameName.Text = g.Name;
            textBoxGenre.Text = g.Genre;
            textBoxPlatform.Text = g.Platform;
            comboBoxCompany.Text = g.Company.CompanyName;
            dateTimePickerReleaseDate.Value = g.ReleaseDate;
            this.Text = "Edit" + game.Name;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (t == "new")
            {
                Game g = new Game(textBoxGameName.Text, textBoxGenre.Text, textBoxDescription.Text, textBoxPlatform.Text, dateTimePickerReleaseDate.Value, Company.getID(comboBoxCompany.Text, user.Id));
                if (!g.Exists())
                {
                    g.New();

                    //CompanyManager.companyManager..RefreshCompanies();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Game Exists");
                }
            }
            else if (t == "edit")
            {
                game.Name = textBoxGameName.Text;
                game.Genre = textBoxGenre.Text;
                game.Platform = textBoxPlatform.Text;
                game.Description = textBoxDescription.Text;
                game.ReleaseDate = dateTimePickerReleaseDate.Value;
                game.CompanyId = Company.getID(comboBoxCompany.Text, user.Id);
                game.Update();
            }
        }
    }
}
