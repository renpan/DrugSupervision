using System;
using  System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace ManagementCenter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Dictionary<string, Form> FormMap = new Dictionary<string, Form>();
        private Form  CreteFormUsgmName(string formName)
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            System.Type t = assem.GetType("ManagementCenter." + formName);
            object obj = null;
            if (t != null)
                obj = Activator.CreateInstance(t);

            Form form = null;
            if (obj != null)
            {
                form=(obj as Form);
            }
           
            return form;
        }

        public void ShowForm(string formName)
        {
            string className = formName;
            Form client = null;
            if (FormMap.ContainsKey(className) )
            {
                if (FormMap[className] != null)
                {
                    client = FormMap[className] as Form;
                    if (client.IsDisposed)
                    {
                        client = this.CreteFormUsgmName(className);
                        FormMap[className] = client;
                    }
                }
                else
                {
                    //窗体类名已经出现在列表，但窗体为NULL，说明无法根据窗体类名创建对象。
                }
            }
            else
            {
                client = this.CreteFormUsgmName(className);
                FormMap.Add(className, client);
               
            }


            if (client != null)
            {
                client.TopLevel = false;
                client.Opacity = 0.1;
                client.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(client);
                client.Dock = DockStyle.Fill;
                //client.Parent = this.splitContainer1.Panel2;
                client.Visible = true;
            }
          
        }

        private void FoldingButtonItem_Click(object sender, EventArgs e)
        {

            OpenSource.PhhSoft.Support.FoldingButtonItem item = sender as OpenSource.PhhSoft.Support.FoldingButtonItem;

            string text = item.Name;
            string formName = string.Empty;
            if (text.Equals("btnDrugInfo"))
            {
                formName = "InfoDrug";
            }
            else if (text.Equals("btnDrugBatch"))
            {
                formName = "InfoDrugBatch";
            }
            else if (text.Equals("btnDrugCode"))
            {
                formName = "InfoDrugCode";
            }
            else if (text.Equals("btnTask"))
            {
                formName = "TaskManager";
            }
            else if (text.Equals("btnCodeGather"))
            {
                formName = "CodeGather";
            }
            else if (text.Equals("btnPackageScattered"))
            {

            }else  if (text.Equals("btnPackageIntegrated"))
            {

            }else  if (text.Equals(""))
            {

            }else  if (text.Equals(""))
            {

            }else  if (text.Equals(""))
            {

            }else  if (text.Equals(""))
            {

            }else  if (text.Equals(""))
            {

            }else  if (text.Equals(""))
            {

            }
            else
            {

            }

            ShowForm(formName);
        }
       
      
    }
}
