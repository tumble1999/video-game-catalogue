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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vGCDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vGCDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vGCDataSet.Users);

        }

        private void usersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.vGCDataSet1);

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vGCDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.vGCDataSet1.Users);

        }
    }
}
