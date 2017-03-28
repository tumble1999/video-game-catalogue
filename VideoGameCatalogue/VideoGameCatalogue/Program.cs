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
            /*try
            {*/
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GamesList());
            //Application.Run(new GameInfo("GameName", "Genre", "Description", "Publisher","Platform", DateTime.Parse("8/12/2016")));
            /*}
            catch (Exception e)
            {
                MessageBox.Show("Data: " + e.Data + "\n\nHelpLink: " + e.HelpLink + "\n\nHResult: " + e.HResult + "\n\nInnerException: " + e.InnerException + "\n\nMessage: " + e.Message + "\n\nSource: " + e.Source + "\n\nStackTrace: " + e.StackTrace + "\n\nTargetSite: " + e.TargetSite);
                //throw;
            }*/
        }
    }
}
