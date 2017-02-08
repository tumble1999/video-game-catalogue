using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue;
using VideoGameCatalogue.Properties;
using VideoGameCatalogue.VGCDataSetTableAdapters;

namespace VideoGameCatalogue
{

    public class User
    {
        private int id;
        private string username, password;
        private bool loggedIn;
        internal static readonly User empty = new User("Guest", "") {
            loggedIn = false
        };
        private Review[] reviews;
        private VGCDataSet vgcDataSet = new VGCDataSet();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public string Name
        {
            get
            {
                return username;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool LoggedIn
        {
            get
            {
                return loggedIn;
            }
        }

        public Review[] Reviews
        {
            get
            {
                return reviews;
            }

            set
            {
                reviews = value;
            }
        }

        internal void Register()
        {

            // Create a new row.
            VGCDataSet.UsersRow newUsersRow;
            newUsersRow = vgcDataSet.Users.NewUsersRow();
            newUsersRow.Username = username;
            newUsersRow.Password = password;

            // Add the row to the Region table
            this.vgcDataSet.Users.Rows.Add(newUsersRow);

            // Save the new row to the database
            this.usersTableAdapter.Update(this.vgcDataSet.Users);



            Login();
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.id = -1;
            
        }

        public void Login()
        {
            id = getID(username, password);
            
            loggedIn = id != -1;

            Reviews = Review.GetReviews.User(id, username);
        }

        public bool Exists()
        {
            return getID(username) != -1;
        }

        public void Logout()
        {
            loggedIn = false;
        }

        public static int getID(string u, string p)
        {
            int output = -1;

            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Users";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetString(1) == u && reader.GetString(2) == p)
                {
                    output = reader.GetInt32(0);
                    break;
                }
            }
            
            reader.Close();
            conn.Close();
                return output;
            
        }

        public static int getID(string u)
        {
            int output = -1;

            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Users";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(1) == u)
                {
                    output = reader.GetInt32(0);
                    break;
                }
            }

            reader.Close();
            conn.Close();
            return output;

        }
    }
}
