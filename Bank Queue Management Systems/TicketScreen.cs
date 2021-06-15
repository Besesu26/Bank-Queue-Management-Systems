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
using System.Data.OleDb;

namespace Bank_Queue_Management_Systems
{
    public partial class TicketScreen : Form
    {
        public TicketScreen(String password)
        {
            InitializeComponent();
            this.Passwork = password;
        }

        private String Passwork { get; set; }

        private void TicketScreen_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Password password = new Password(Passwork);
            password.ShowDialog();
            if (password.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {

            Ticket ticket = new Ticket("T");
 
            ticket.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket("W");

            ticket.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket("I");

            ticket.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket("U");

            ticket.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket("C");

            ticket.ShowDialog();
        }
    }
}
