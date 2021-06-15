using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Bank_Queue_Management_Systems.model;

namespace Bank_Queue_Management_Systems.Dao
{
    class clsLoginDao
    {

    public loginModel getLoginDao(string loginName)
        {
            loginModel loginModel = new loginModel();
            OleDbConnection con = clsConnectToDatabase.getConnection();
            string command = "SELECT ID, username, password, role from tbl_user where username ='" + loginName + "'";
            OleDbCommand cmd = new OleDbCommand(command, con);
            OleDbDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    loginModel.Id = int.Parse(data["ID"].ToString());
                    loginModel.Login_name = data["username"].ToString();
                    loginModel.Password = data["password"].ToString();
                    loginModel.Role = data["role"].ToString();
                }
                data.Close();
                con.Close();
                return loginModel;
            }
            else
            {
                data.Close();
                con.Close();
                return null;
            }
        }
    }
}
