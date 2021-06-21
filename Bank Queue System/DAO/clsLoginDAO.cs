using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Queue_System.DTO;
using System.Data.OleDb;
using Bank_Queue_System.Repository;

namespace Bank_Queue_System.DAO
{
    class clsLoginDAO
    {
        public static Login_DTO GetLogin(string loginName)
        {
            Login_DTO login = new Login_DTO();
            OleDbConnection connection = clsConnectToDatabase.getConnection();
            string command = "SELECT * from tbluser where user_login ='" + loginName + "'";
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            OleDbDataReader data = oleDbCommand.ExecuteReader();

            if (data.HasRows)
            {
                while (data.Read())
                {
                    login.Id = int.Parse(data["user_id"].ToString());
                    login.Login_name = data["user_login"].ToString();
                    login.Password = data["user_pass"].ToString();
                    login.Name = data["user_name"].ToString();
                }
                data.Close();
                connection.Close();
                return login;
            }
            else
            {
                data.Close();
                connection.Close();
                return null;
            }
        }
    }
}
