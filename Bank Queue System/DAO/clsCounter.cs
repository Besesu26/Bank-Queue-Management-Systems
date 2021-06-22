using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Queue_System.DTO;
using System.Data.OleDb;
using Bank_Queue_System.Repository;
using System.Collections;

namespace Bank_Queue_System.DAO
{
    class clsCounter
    {
        public static ArrayList GetCounter()
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "SELECT counter_id from tblcounter where is_login = false";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            OleDbDataReader data = oleDbCommand.ExecuteReader();
            ArrayList array = new ArrayList();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    array.Add(data["counter_id"]);
                }
                data.Close();
                connection.Close();
                return array;
            }
            else
            {
                data.Close();
                connection.Close();
                return null;
            }
        }

        public static ArrayList GetCounterStatus()
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "SELECT counter_id from tblcounter where is_unavailable = false";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            OleDbDataReader data = oleDbCommand.ExecuteReader();
            ArrayList array = new ArrayList();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    array.Add(data["counter_id"]);
                }
                data.Close();
                connection.Close();
                return array;
            }
            else
            {
                data.Close();
                connection.Close();
                return null;
            }
        }

        public static void SetCounter(string counterID,int userID)
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "UPDATE tblcounter SET is_login = true,user_id = "+userID+" WHERE counter_id='"+counterID+"'";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
        }
        
        public static void StatusCounter(string counterID)
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "UPDATE tblcounter SET is_unavailable = true WHERE counter_id='"+counterID+"'";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void ClearStatusCounter(string counterID)
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "UPDATE tblcounter SET is_unavailable = false WHERE counter_id='" + counterID + "'";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void ResetCounter(string counterID)
        {
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "UPDATE tblcounter SET is_login = false,user_id = null WHERE counter_id='" + counterID + "'";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            oleDbCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
