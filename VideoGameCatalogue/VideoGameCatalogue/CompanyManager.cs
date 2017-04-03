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
        Game[] games;
        public CompanyManager(ref User u)
        {
            user = u;
            InitializeComponent();
            List<Game> tmpGames = new List<Game>();
            foreach (Company company in u.Companies)
            {
                foreach (var game in company.Games)
                {
                    tmpGames.Add(game);
                    listViewGames.Items.Add(new ListViewItem(new string[] { game.Company.CompanyName, game.Name, game.Genre, game.Platform, game.ReleaseDate.ToShortDateString(), game.Description }));
                }
                
            }
            games = tmpGames.ToArray();
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

        private void CompanyManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            new NewGame(user).Show();
        }

        private void buttonEditGame_Click(object sender, EventArgs e)
        {
            new NewGame(user, games[listViewGames.CheckedIndices[0]]).Show();
        }
    }
}
