using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.id = getID(companyName,userID);
            this.companyName = companyName;
            this.userID = userID;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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
            string sql = "SELECT * FROM Companys";
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
            string sql = "SELECT * FROM Company WHERE UserID=" + u.Id;
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
    }
}
