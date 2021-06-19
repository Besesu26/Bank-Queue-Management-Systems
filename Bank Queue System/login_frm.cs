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
    public partial class login_frm : Form
    {
        public login_frm()
        {
            InitializeComponent();
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPass.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            counter_screen_frm counter = new counter_screen_frm();
            counter.Show();
        }
    }
}
