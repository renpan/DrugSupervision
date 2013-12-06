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
        private Main()
        {
            InitializeComponent();            
        }

        private static Main instance = new Main();
        public static Main GetInstance()
        {
            if (null == instance)
                instance = new Main();
            return instance;
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
                client.Dock = DockStyle.Fill;

                this.splitContainer1.Panel2.Controls.Clear();
                this.splitContainer1.Panel2.Controls.Add(client);

                client.Visible = true;
            }
          
        }

        private void FoldingButtonItem_Click(object sender, EventArgs e)
        {

            OpenSource.PhhSoft.Support.FoldingButtonItem item = sender as OpenSource.PhhSoft.Support.FoldingButtonItem;

            string text = item.Name;
            string formName = string.Empty;
            // 数据文件管理
          
            if (text.Equals("btnDrugInfo"))
            {
                formName = "InfoDrug";
            }
          
            else if (text.Equals("btnCodeFile"))
            {
                formName = "InfoDrugCode";
            }
            else if (text.Equals("btnDataExport"))
            {
                formName = "InfoPackageData";
            }
            else if (text.Equals("btnDataStore"))
            {
                formName = "PackageDataStore";
            }
            // 生产管理
            else if (text.Equals("btnTask"))
            {
                formName = "TaskManager";
            }
            else if (text.Equals("btnCodeGather"))
            {
                formName = "CodeGather";
            }
            // 异常管理
            else if (text.Equals("btnPackageScattered"))
            {
                formName = "PackageScattered";

            }
            else if (text.Equals("btnPackageIntegrated"))
            {
                formName = "PackageIntegrated";
            }
            // 基础数据
            else if (text.Equals("btnPackageCriterion"))
            {
                formName = "PackageCriterion";
            }
            else if (text.Equals("btnCodePrint"))
            {
                formName = "CodePrint";
            }
            else if (text.Equals("btnDrugBatch"))
            {
                formName = "InfoDrugBatch";
            }
            if(formName != string.Empty)
                ShowForm(formName);
        }
       
      
    }
}
