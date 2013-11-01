using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DrugSupervise.Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Form> forms;//= new List<Form>();



        private void MainForm_Load(object sender, EventArgs e)
        {
            forms = new List<Form>();

            foreach (Control control in this.Controls)
            {
                if (control.GetType().ToString().Contains("Windows.Forms.Button"))
                {
                    control.Click += new EventHandler(control_Click);
                    control.MouseHover += new EventHandler(
                            delegate(object sd, EventArgs args)
                            {
                                ((Button)sd).Focus();
                            });
                }
            }
        }

        void control_Click(object sender, EventArgs e)
        {
            string desc = ((Button)sender).Name.Substring(3);
            Type type = Type.GetType("DrugSupervise.Demo." + desc + "Form");
            if (type != null)
            {
                object form = type.Assembly.CreateInstance("DrugSupervise.Demo." + desc + "Form");
                ((Form)form).Show();
                ((Button)sender).Enabled = false;

                ((Form)form).FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            }
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Button button in this.Controls)
            {
                if (((Form)sender).Name.Contains(button.Name.Substring(3)))
                {
                    button.Enabled = true;
                }

            }
        }
    }
}
