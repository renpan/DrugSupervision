using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementCenter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.button1_Click(this.button1, null);
        }

        Main m = Main.GetInstance();
        private void button2_Click(object sender, EventArgs e)
        {
            
            m.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool expanded = true;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                this.button1.Text = "服务器设置↓";
                this.Height -= this.groupBox1.Height+20;
               
            }
            else
            {
                this.button1.Text = "服务器设置↑";

                this.Height += this.groupBox1.Height+20;
            }
            expanded = !expanded ;
            this.groupBox1.Visible = expanded;
        }
    }
}
