using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(!user.Exists() && user != User.empty)
            {
                user = User.empty;
                Update();
            }
        }
    }
    
}
