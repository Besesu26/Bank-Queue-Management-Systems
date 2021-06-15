using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Queue_Management_Systems
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

     

        private void btnTicket_Click_1(object sender, EventArgs e)
        {
            Login_frm login = new Login_frm();
            login.ShowDialog();
            //TicketScreen ticketScreen = new TicketScreen();
            //ticketScreen.Show();
        }
    }
}
