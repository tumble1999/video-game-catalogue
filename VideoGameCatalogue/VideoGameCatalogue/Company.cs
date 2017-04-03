using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public class Company
    {
        private int id;
        private string companyName;
        private int userID;
        private string userName;

        public Company(int id, string companyName, int userID)
        {
            this.id = id;
            this.companyName = companyName;
            this.userID = userID;
        }
        public Company(string companyName, int userID)
        {
            this.companyName = companyName;
            this.userID = userID;
        }

        public int Id
        {
            get
            {
                return getID(companyName, userID); ;
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public Game[] Games
        {
            get
            {
                return Game.GetGames(this);
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public static int getID(string n, int u)
        {
            int output = -1;

            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Companies";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(1) == n && reader.GetInt32(2) == u)
                {
                    output = reader.GetInt32(0);
                    break;
                }
            }

            reader.Close();
            conn.Close();
            return output;

        }
        
        public static Company[] GetCompanies(User u)
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Companies WHERE UserID=" + u.Id;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            IList<Company> tmpCompanies = new List<Company>();
            //int i = 1;
            
            while (reader.Read())
            {
                tmpCompanies.Add(new Company(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }
            reader.Close();
            conn.Close();
            return tmpCompanies.ToArray();
        }
        public static Company GetCompany(int id)
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Companies WHERE CompanyID=" + id;
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            //IList<Company> tmpCompanies = new List<Company>();]
            Company tmpCompany = null;
            //int i = 1;

            while (reader.Read())
            {
                tmpCompany = new Company(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }
            reader.Close();
            conn.Close();
            return tmpCompany;
        }
        internal void Update()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("UPDATE Companies SET ComapnyName = @CompanyName, UserID = @UserID WHERE CompanyID = @id");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@CompanyName", companyName);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@id", Id);

                //MessageBox.Show(cmd.CommandText);

                //try
                //{
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();
                //}
                //catch (OleDbException e)
                //{
                //    MessageBox.Show("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                //    conn.Close();
                //}


            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
        internal void New()
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);

            OleDbCommand cmd = new OleDbCommand("INSERT into Companies (CompanyName, UserID) Values(@CompanyName, @UserID) ");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                //MessageBox.Show(cmd.CommandText);

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Data Added");
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

            Update();


        }
        public bool Exists()
        {
            return getID(companyName, userID) != -1;
        }
    }
}
