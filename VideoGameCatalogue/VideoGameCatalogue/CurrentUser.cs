using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCatalogue
{
    class CurrentUser
    {
        public static User user = User.empty;
        public static int userID;
        public static string username, password;

        public static void Update()
        {
            username = user.Username;
            password = user.Password;
            userID = user.Id;
        }
    }
    
}
