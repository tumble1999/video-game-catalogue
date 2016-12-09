using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameCatalogue
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GamesList());
            Application.Run(new GameInfo("Hello i am a game", "Action", "This game is about the fact that it is a game", "Wow Studios","Pi (3.1415...)", DateTime.Now));
        }
    }
}
