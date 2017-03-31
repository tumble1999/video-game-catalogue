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
    public partial class CompanyManager : Form
    {
        User user;
        public CompanyManager(ref User u)
        {
            user = u;
            InitializeComponent();
            foreach (Company company in u.Companies)
            {
                foreach (var game in company.Games)
                {
                    listViewGames.Items.Add(new ListViewItem(new string[] { game.Company.CompanyName, game.Name, game.Genre, game.Platform, game.ReleaseDate.ToShortDateString(), game.Description }));
                }
                
            }
        }

        private void listViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCompanies_Click(object sender, EventArgs e)
        {
            new Companies(ref user).Show(); ;
        }

        private void listViewGames_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            buttonEditGame.Enabled = listViewGames.CheckedItems.Count == 1;
            buttonDeleteGame.Enabled = listViewGames.CheckedItems.Count >= 1;
        }
    }
}
