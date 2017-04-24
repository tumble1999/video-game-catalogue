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
using System.Security.Cryptography;
using System.IO;

namespace VideoGameCatalogue
{

    public class User
    {
        private int id;
        private string username, password, hashedPassword;
        private bool loggedIn;
        public static readonly User empty = new User("Guest", "") {
            loggedIn = false
        };
        //private Review[] reviews;
        //private Company[] companies
        private VGCDataSet vgcDataSet = new VGCDataSet();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();


        //HASHING VARS

        //
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

        public string HashedPassword
        {
            get
            {
                return hashedPassword;
            }

            set
            {
                hashedPassword = value;
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
                return Review.GetReviews.User(this);
            }
        }

        public Company[] Companies
        {
            get
            {
                return Company.GetCompanies(this);
            }
        }

        internal void Update()
        {

            HashedPassword = Hash(password);
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("UPDATE Users SET Username = @Username, [Password] = @Password WHERE UserID = @id");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", HashedPassword);
                cmd.Parameters.AddWithValue("@id", Id);

                Console.WriteLine(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated");
                    conn.Close();
                }
                catch (OleDbException e)
                {
                    Console.WriteLine("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                    conn.Close();
                }


            }
            else
            {
                Console.WriteLine("Connection Failed");
            }
        }

        internal void Register()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            HashedPassword = Hash(password);
            OleDbCommand cmd = new OleDbCommand("INSERT into Users (Username, [Password]) Values(@Username, @Password) ");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", HashedPassword);

                Console.WriteLine(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Added");
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine(ex.Source);
                    conn.Close();
                }

                
            }
            else
            {
                Console.WriteLine("Connection Failed");
            }
            
            Update();
            

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.id = -1;
            
        }
        public User(int id, string username)
        {
            this.username = username;
            this.id = id;

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
            Console.WriteLine("ID:" + id);
            loggedIn = id != -1;
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
                if(reader.GetString(1) == u && reader.GetString(2) == Hash(p))
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

        public User getUser(int id)
        {
            User output = User.empty;

            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Users WHERE UserID=" + id;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                output = new User(reader.GetInt32(0), reader.GetString(1)) {
                    hashedPassword = reader.GetString(2)
                };
            }

            reader.Close();
            conn.Close();

            return output;
        }



        public static string Hash(string input)
        {
            SHA512Managed hasher = new SHA512Managed();
            byte[] byteArray = hasher.ComputeHash(Encoding.ASCII.GetBytes(input));
            string output = Convert.ToBase64String(byteArray);

            /*Form message = new Form()
            {
                Text = "INPUT: " + input
            };
            TextBox textBox = new TextBox()
            {
                Text = output,
                Multiline = true,
                //WordWrap = true,
                Dock = DockStyle.Fill
            };
            message.Controls.Add(textBox);
            message.Show();*/

            //MessageBox.Show("OUTPUT: " + output, "INPUT: " + input);

            Console.WriteLine("");
            Console.WriteLine("HASHING...");
            Console.WriteLine("INPUT: " + @input);
            Console.WriteLine("OUTPUT: " + @output);
            return output;
        }
    }
}
