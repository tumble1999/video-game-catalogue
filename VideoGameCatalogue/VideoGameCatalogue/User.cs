using System;
using System.Collections.Generic;
using System.Data;
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
        public static readonly User empty = new User("Guest", "") {
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
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("INSERT into Users (Username, [Password]) Values(@Username, @Password) ");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    conn.Close();
                }

                
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            
            cmd = new OleDbCommand("UPDATE Users SET Username = @Username, [Password] = @Password WHERE UserID = @id");
            cmd.Connection = conn;

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@id",Id);

                MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();
                }
                catch (OleDbException e)
                {
                    MessageBox.Show("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.id = -1;
            
        }
        public User(int id, string username, string password)
        {
            this.username = username;
            this.password = password;
            this.id = id;

        }

        public void Login()
        {
            id = getID(username, password);
            
            loggedIn = id != -1;

            Reviews = Review.GetReviews.User(this);
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
