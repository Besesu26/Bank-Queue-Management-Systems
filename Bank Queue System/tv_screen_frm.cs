using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Bank_Queue_System
{
    public partial class tv_screen_frm : Form
    {
        public tv_screen_frm()
        {
            InitializeComponent();
        }

        public  void displayTicket(string counterID,string ticketNum)
        {
            if(counterID == "Counter 1")
            {
               lb_ticket1.Text = ticketNum;
            }else if (counterID == "Counter 2")
            {
                lb_ticket2.Text = ticketNum;
            }else if(counterID == "Counter 3")
            {
               lb_ticket3.Text = ticketNum;
            }else if (counterID == "Counter 4")
            {
                lb_ticket4.Text = ticketNum;
            }else if (counterID == "Counter 5")
            {
                lb_ticket5.Text = ticketNum;
            }else if (counterID == "Counter 6")
            {
                lb_ticket6.Text = ticketNum;
            }

            string toSpeak = "Ticket "+ticketNum+"please go to "+counterID ;
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
            speechSynthesizer.Rate = -1;
            speechSynthesizer.SpeakAsync(toSpeak);

        }

        public void clearDisplay(string counterID)
        {
            if (counterID == "Counter 1")
            {
                lb_ticket1.Text = "";
            }
            else if (counterID == "Counter 2")
            {
                lb_ticket2.Text = "";
            }
            else if (counterID == "Counter 3")
            {
                lb_ticket3.Text = "";
            }
            else if (counterID == "Counter 4")
            {
                lb_ticket4.Text = "";
            }
            else if (counterID == "Counter 5")
            {
                lb_ticket5.Text = "";
            }
            else if (counterID == "Counter 6")
            {
                lb_ticket6.Text = "";
            }
        }
      

        private void tv_screen_frm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
