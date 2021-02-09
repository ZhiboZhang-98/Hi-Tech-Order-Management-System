using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Hi_Tech_Order_Management_System.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection connDB()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionHi-TechDB"].ConnectionString;
            sqlconn.Open();
            return sqlconn;
        }
    }
}
