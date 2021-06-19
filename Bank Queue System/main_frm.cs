using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Queue_System
{
    public partial class main_frm : Form
    {
        public main_frm()
        {
            InitializeComponent();
        }

        private void btn_counter_Click(object sender, EventArgs e)
        {
            login_frm login= new login_frm();
            login.Show();
        }

        private void btn_ticketScreen_Click(object sender, EventArgs e)
        {
            ticket_screen_frm ticket = new ticket_screen_frm();
            ticket.Show();
        }
    }
}
