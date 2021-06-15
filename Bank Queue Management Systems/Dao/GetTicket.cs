using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Bank_Queue_Management_Systems.Dao
{
    class GetTicket
    {
     public string getTicketNumber( String type)
        {
            OleDbConnection con = clsConnectToDatabase.getConnection();
            string command = "SELECT TOP 1 *From tbl_ticket ORDER BY ID DESC";
            OleDbCommand cmd = new OleDbCommand(command, con);
            var data =    cmd.ExecuteScalar();
           
            if (data != null)
            {
                int newTicketNum = int.Parse(data.ToString())+1;
                string add = $"INSERT INTO tbl_ticket (Ticket_type) VALUES ('{type}')";
                OleDbCommand oleDbCommand = new OleDbCommand(add, con);
                oleDbCommand.ExecuteReader();
                return type+ newTicketNum.ToString("D3");
                con.Close();
            }
            else
            {
                string add = $"INSERT INTO tbl_ticket (Ticket_type) VALUES ('{type}')";
                OleDbCommand oleDbCommand = new OleDbCommand(add, con);
                oleDbCommand.ExecuteReader();
                return $"{type}001";
                con.Close();
            }
           
        }

    }
}
