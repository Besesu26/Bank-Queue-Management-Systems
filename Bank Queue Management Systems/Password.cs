using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Bank_Queue_Management_Systems
{
    public partial class Password : Form
    {
        public Password(String password)
        {
            InitializeComponent();
           PasswordCheck = password;
        }

        private String PasswordCheck { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
         
            if (textBox1.Text == PasswordCheck) {
                OleDbConnection con = clsConnectToDatabase.getConnection();
                string command = "ALTER TABLE tbl_ticket ALTER COLUMN ID COUNTER(1,1)";
                OleDbCommand clearAutonumber = new OleDbCommand(command, con);
                clearAutonumber.ExecuteScalar();
                string deletecommand = "DELETE From tbl_ticket";
                OleDbCommand delete = new OleDbCommand(deletecommand, con);
                delete.ExecuteReader();
                this.DialogResult = DialogResult.OK;
               

            }
            else
            {
                MessageBox.Show("Incorrect Password Please try again!");
            }
        }
    }
}
