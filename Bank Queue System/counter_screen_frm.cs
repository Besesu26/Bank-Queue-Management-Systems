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
    public partial class counter_screen_frm : Form
    {
        public counter_screen_frm()
        {
            InitializeComponent();
        }

        private void counter_screen_frm_Load(object sender, EventArgs e)
        {
            ticket_List.Columns.Add("MyColumn");
            ticket_List.FullRowSelect = true;
            ticket_List.GridLines = true;
            ticket_List.View = System.Windows.Forms.View.List;
            foreach (int ticket_Num in Ticket_DTO.ticket_queue)
            {
                ListViewItem lvi = new ListViewItem(ticket_Num.ToString("D3"));
                ticket_List.Items.Add(lvi);
            }
        }

       
    }
}
