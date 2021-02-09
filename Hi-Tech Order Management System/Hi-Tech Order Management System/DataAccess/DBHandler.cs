using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Hi_Tech_Order_Management_System
{
    class DBHandler
    {
        protected string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + Application.StartupPath + "\\Database.mdf";
        //Console.Write("");
        protected SqlConnection con;

    }
}
