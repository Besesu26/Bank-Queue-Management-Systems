using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Queue_System.DTO;

namespace Bank_Queue_System
{
    public partial class ticket_screen_frm : Form
    {
        public ticket_screen_frm()
        {
            InitializeComponent();
        }

        int Ticket = 0;
        private void get_ticke()
        {
            if (Ticket == 0)
            {
                Ticket++;
                Ticket_DTO.ticket_queue.Add(Ticket);
                ticket_frm ticket = new ticket_frm("001");
               
                ticket.Show();
            }
            else
            {
                //int lastIndex = Ticket_DTO.ticket_queue.Count - 1;
                // int lastTicket = (int)Ticket_DTO.ticket_queue[lastIndex];
                Ticket++;
                Ticket_DTO.ticket_queue.Add(Ticket);
                ticket_frm ticket = new ticket_frm((Ticket).ToString("D3"));
      
                ticket.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            get_ticke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_ticke();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_ticke();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            get_ticke();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            get_ticke();
        }
    }
}
