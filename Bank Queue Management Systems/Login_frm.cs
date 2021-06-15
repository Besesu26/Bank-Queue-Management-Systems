using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Queue_Management_Systems.Dao;
using Bank_Queue_Management_Systems.model;



namespace Bank_Queue_Management_Systems
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(showPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
       
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsLoginDao login = new clsLoginDao();
            loginModel loginModel = login.getLoginDao(txtLoginName.Text);
            if (txtLoginName.Text != "" && loginModel != null)
            {
                if (txtPassword.Text == loginModel.Password && loginModel.Role == "admin")
                {
                    TicketScreen ticket = new TicketScreen(loginModel.Password);
                    ticket.Show();
                }else if (loginModel.Role != "admin")
                {
                    MessageBox.Show("You have no permission to enter this page!");
                }
                else
                {
                    MessageBox.Show("Incorrect username or password please try again!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password please try again!");
            }
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
