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
        public NewGame(User u)
        {
            InitializeComponent();
            foreach (Company company in u.Companies)
            {
                comboBoxComapny.Items.Add(company.CompanyName);
            }
        }
        public NewGame(User u, Game g)
        {
            InitializeComponent();
            textBoxDescription.Text = g.Description;
            textBoxGameName.Text = g.Name;
            textBoxGenre.Text = g.Genre;
            textBoxPlatform.Text = g.Platform;
            comboBoxComapny.Text = g.Company.CompanyName;
            dateTimePickerReleaseDate.Value = g.ReleaseDate;
            
        }
    }
}
