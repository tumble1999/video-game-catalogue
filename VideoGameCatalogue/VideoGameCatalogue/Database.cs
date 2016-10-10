using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace VideoGameCatalogue
{
    class Database
    {
        String conn_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\10trow.c\Source\Repos\Video Game Catalogue\VideoGameCatalogue\VideoGameCatalogue\VGC.accdb";
        String error_msg = "";
        String q = "";
        OleDbConnection conn = null;
    }
}
