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

namespace Bank_Queue_Management_Systems
{
    public partial class Ticket : Form
    {
        public Ticket(String type)
        {
            InitializeComponent();
            this.Type = type;
        }

        public string Type { get; set; }
        private void Ticket_Load(object sender, EventArgs e)
        {
            GetTicket getTicket = new GetTicket();

            tick_num.Text = getTicket.getTicketNumber(Type);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

    }
}
