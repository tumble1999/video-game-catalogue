using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Review[] GetReviews(int gameId)
        {
            OleDbConnection conn = new OleDbConnection(new Settings().VGCConnectionString);
            string sql = "SELECT * FROM Reviews";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            IList<Review> tmpGames = new List<Review>();
            //int i = 1;

            ///add only game ID
            while (reader.Read())
            {
                if (reader.GetInt32(2) == GameID)
                {
                    // currentGameId = reader.GetString(0);
                    tmpGames.Add(new Review());
                }
            }
            games = tmpGames.ToArray();
            reader.Close();
            conn.Close();
        }
        public int GetAverage(Review[] rArray)
        {
            int a = 0;
            foreach (Review r in rArray)
            {
                a += r.Rating;
            }
            a = a / rArray.Length;
            return a;
        }
    }
}
