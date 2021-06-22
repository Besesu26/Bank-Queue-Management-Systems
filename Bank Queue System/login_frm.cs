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
using Bank_Queue_System.DTO;

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


        public static counter_screen_frm CounterScreen;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_pass.Text != "" && comboBox1.SelectedItem != null)
            {
           Login_DTO login = clsLoginDAO.GetLogin(txt_username.Text);
                if (login != null)
                {
                    if (login.Password == txt_pass.Text)
                    {
                        clsCounter.SetCounter(comboBox1.SelectedItem.ToString(),login.Id);
                        CounterScreen = new counter_screen_frm(comboBox1.SelectedItem.ToString(),login.Name);
                        CounterScreen.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password please try again!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username please try again!");
                }
                
            }
            else if(txt_username.Text == "")
            {
                MessageBox.Show("Please input username");
            }
            else if (txt_pass.Text == "")
            {
                MessageBox.Show("Please input password");
            }
            else
            {
                MessageBox.Show("Please Select Counter");
            }
           
            
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            ArrayList counter = clsCounter.GetCounter();
           if(counter!= null)
            {
                foreach (object id in counter)
                {
                    comboBox1.Items.Add(id.ToString());
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Sorry there were no counter available");
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
