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
    public partial class ticket_frm : Form
    {
        public ticket_frm(String ticketnum)
        {
            InitializeComponent();
            ticket_Num = ticketnum;
           
        }

        private String ticket_Num { get; set; }

        private void ticket_frm_Load(object sender, EventArgs e)
        {
            ticket_num.Text = ticket_Num;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
