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
using Bank_Queue_System.DAO;

namespace Bank_Queue_System
{
    public partial class counter_screen_frm : Form
    {
        public counter_screen_frm(string counter,string name)
        {
            InitializeComponent();
            counterID = counter;
            username = name;
        }

        private String username;
        private void counter_screen_frm_Load(object sender, EventArgs e)
        {
          
            foreach (int ticket_Num in Ticket_DTO.ticket_queue)
            {
                ticket_List.Rows.Add(ticket_Num.ToString("D3"));
            }
            lb_name.Text = username;
            timer1.Start();
            timer3.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Date.Text = DateTime.Now.ToLongDateString();
            lb_time.Text = DateTime.Now.ToLongTimeString();
        }


        int h,m,s;
        bool _isStart = false;
       
        public String counterID { get; set; }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            clsCounter.ResetCounter(counterID);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(btn_start.Text != "Stop")
            {
                if (Ticket_DTO.ticket_queue.Count > 0)
                {
                    int firstTicket = (int)Ticket_DTO.ticket_queue[0];
                    lb_ticket.Text = firstTicket.ToString("D3");
                    Ticket_DTO.ticket_queue.RemoveAt(0);
                    if (main_frm.tv_Screen != null)
                    {
                        main_frm.tv_Screen.displayTicket(counterID, lb_ticket.Text);
                    }
                    else
                    {
                        MessageBox.Show("TV Display is not open!");
                    }

                }
                else
                {
                    MessageBox.Show("Sorry there was no ticket available");
                }
            }
            else
            {
                MessageBox.Show("Please click stop to clear your old ticket first before get the next one");
            }
           
          
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ticket_List.Rows.Clear();
            foreach (int ticket_Num in Ticket_DTO.ticket_queue)
            {
                ticket_List.Rows.Add(ticket_Num.ToString("D3"));
            }
        }

        private void btn_Recall_Click(object sender, EventArgs e)
        {
            if(lb_ticket.Text != "" && btn_start.Text=="Start")
            {
                if (main_frm.tv_Screen != null)
                {
                    main_frm.tv_Screen.displayTicket(counterID, lb_ticket.Text);
                }
                else
                {
                    MessageBox.Show("TV Display is not open!");
                }
            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (lb_ticket.Text != "") 
            {
                if (_isStart == false)
                {
                    timer2.Start();
                    btn_start.Text = "Stop";
                    _isStart = true;
                }
                else
                {
                    timer2.Stop();
                    _isStart = false;
                    btn_start.Text = "Start";
                    lb_timer.Text = "00:00:00";
                    h = 0;
                    m = 0;
                    s = 0;
                    lb_ticket.Text = "";
                    main_frm.tv_Screen.clearDisplay(counterID);
                  
                }
               
            }
            else
            {
                MessageBox.Show("You Have No Ticket Right Now, Please Click Next To Get Your Ticket!");
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s <= 59)
            {
                s++;
            }
            else if (s > 59 && m < 59)
            {
                s = 0;
                m++;
            }
            else 
            {
                m = 0;
                h++; 
            }

            lb_timer.Text = h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2");
        }

    }
}
