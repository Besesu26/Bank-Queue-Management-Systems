using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Queue_System.DAO;

namespace Bank_Queue_System
{
    public partial class tranfer_frm : Form
    {
        public tranfer_frm()
        {
            InitializeComponent();
        }

        private void tranfer_frm_Load(object sender, EventArgs e)
        {
         ArrayList list  = clsCounter.GetCounterStatus();
        foreach (string counter in list)
            {
                if(counter == "Counter 1")
                {
                    btn_counter1.BackColor = Color.Green;
                }else if (counter == "Counter 2")
                {
                    btn_counter2.BackColor = Color.Green;
                }else if (counter == "Counter 3")
                {
                    btn_counter3.BackColor = Color.Green;
                }else if (counter == "Counter 4")
                {
                    btn_counter4.BackColor = Color.Green;
                }else if (counter == "Counter 5")
                {
                    btn_counter5.BackColor = Color.Green;
                }else if (counter == "Counter 6")
                {
                    btn_counter6.BackColor = Color.Green;
                }
            }
        }

        private void btn_counter1_Click(object sender, EventArgs e)
        {
            if(btn_counter1.BackColor == Color.Red)
            {
                MessageBox.Show("Sorry this counter is unavailible right now ,please select another counter");
            }
        }
    }
}
