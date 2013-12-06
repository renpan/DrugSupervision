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
    }
}
