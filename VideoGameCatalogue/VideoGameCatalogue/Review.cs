using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameCatalogue.Properties;

namespace VideoGameCatalogue
{
    public class SuperReview
    {

    }

    public class Review : SuperReview
    {
        private int userID, gameID, rating;
        private string reviewText;

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

        public int GameID
        {
            get
            {
                return gameID;
            }

            set
            {
                gameID = value;
            }
        }

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string ReviewText
        {
            get
            {
                return reviewText;
            }

            set
            {
                reviewText = value;
            }
        }

        public static class GetReviews
        {
            public static Review[] Game(int gameId)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                ///add only game ID
                while (reader.Read())
                {
                    if (reader.GetInt32(2) == gameId)
                    {
                        // currentGameId = reader.GetString(0);
                        tmpReviews.Add(new Review());
                    }
                }

                reader.Close();
                conn.Close();
                return tmpReviews.ToArray();
            }

            public static Review[] User(int userId)
            {
                OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
                string sql = "SELECT * FROM Reviews";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();

                OleDbDataReader reader;
                reader = cmd.ExecuteReader();

                IList<Review> tmpReviews = new List<Review>();
                //int i = 1;

                ///add only game ID
                while (reader.Read())
                {
                    if (reader.GetInt32(1) == userId)
                    {
                        // currentGameId = reader.GetString(0);
                        tmpReviews.Add(new Review(reader.GetInt32(0),reader));
                    }
                }

                reader.Close();
                conn.Close();
                return tmpReviews.ToArray();
            }
        }
        public static int GetAverage(Review[] rArray)
        {
            int a = 0;
            foreach (Review r in rArray )
            {
                a += r.Rating;
            }
            a = a / rArray.Length;
            return a;
        }
    }
}
