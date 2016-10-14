using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCatalogue
{
    class CurrentUser
    {
        public User user = User.empty;
        public int userID;
        public string username, password;

        public static void Update()
        {
            username = user.Username;
            password = user.Password;
            userID = user.Id;
        }
    }
    
}
