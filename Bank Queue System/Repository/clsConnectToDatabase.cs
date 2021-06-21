using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace Bank_Queue_System.Repository
{
    public static class clsConnectToDatabase
    {
        public static string dataString = "";

        public static OleDbConnection getConnection()
        {
            dataString = ConfigurationManager.ConnectionStrings["database"].ToString();
            OleDbConnection con = new OleDbConnection(dataString);
            con.Open();
            return con;
        }
    }
}
