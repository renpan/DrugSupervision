using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;


namespace DrugSupervise.Demo
{
    public partial class ImportForm : Form
    {
        List<string> codes;
        Stream codeStream = null;
        public ImportForm()
        {
            codes = new List<string>();
            InitializeComponent();
        }
        Thread workThread;
        private void cmdOpen_Click(object sender, EventArgs e)
        {
            codes.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName.ToString();
                AddLog("文件已选中" + ofd.FileName.ToString());

                try
                {
                    codeStream = ofd.OpenFile();
                    AddLog("文件已打开");
                    workThread = new Thread(new ThreadStart(LoadCodes));
                    workThread.Start();
                    tmrShowProgress.Start();

                }
                catch (Exception ex)
                {
                    AddLog("打开文件出错", ex);
                }
            }

        }
        bool UserSetPasue;
        bool UserSetExit;
        int codeIndex;
        string[] header;
        private void LoadCodes()
        {
            MySqlConnection connection = null;
            try
            {
                #region 读入药监码
                if (codeStream != null)
                {
                    using (codeStream)
                    {
                        StreamReader sr = new StreamReader(codeStream);
                        string line = null;
                        line = sr.ReadLine();
                        header = line.Split('#');
                        AddLog(string.Format("开始读入监管码,计数{0}", codeIndex));
                        while ((line = sr.ReadLine()) != null)
                        {
                            codes.Add(line);
                            codeIndex++;
                        }
                        AddLog(string.Format("操作完成,监管码全部读入,数量{0}", codeIndex));
                    }
                }
                #endregion

                #region 导入药监码
                connection = new MySqlConnection("server=192.168.1.200;database=Test;uid=Test;pwd=test;charset=utf8;");
                connection.Open();
                AddLog("数据库就绪,准备接收监管码.");
                MySqlCommand command;
                codeIndex = 0;
                AddLog("开始导入监管码.");
                string strCommand = null;
                int step = 1000;          //一次插入几条纪录
                int index = 0;
                bool finished = false;
                while (!UserSetExit)
                {
                    while (!UserSetPasue && !UserSetExit)
                    {
                        if (index < codes.Count)
                        {
                            strCommand = "INSERT INTO packing (barcode,packlevel,state) VALUES";
                            int tick;
                            for (tick = 0; (tick < step) && (index + tick < codes.Count); tick++)
                            {
                                string code = codes[index + tick];
                                strCommand += string.Format("('{0}',{1},1),", code, header[1]);
                            }
                            strCommand = strCommand.Remove(strCommand.Length - 1, 1);
                            command = new MySqlCommand(strCommand, connection);
                            int result;
                            if ((result = command.ExecuteNonQuery()) != step)
                            {
                                AddLog(string.Format("监管码{0}等{1}个导入失败", codes[index], step), new Exception(string.Format("执行SQL语句时返回值为{0}", result)));
                            }
                            codeIndex += tick;

                            index += step;
                        }
                        else
                        {
                            finished = true;
                            break;

                        }
                    }
                    if (!finished)
                        Thread.Sleep(500);
                    else
                        break;
                }

                if (index >= codes.Count)
                    AddLog(string.Format("导入全部完成,数量{0}.", codeIndex));
                else
                    AddLog("用户取消操作.");
                #endregion

            }
            catch (MySqlException exSQL)
            {
                AddLog("操作中止,导入监管码时出错", exSQL);
            }
            catch (Exception ex)
            {
                AddLog(string.Format("操作中止,读入监管码时出错,计数{0}", codeIndex), ex);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
                this.BeginInvoke(new MethodInvoker(delegate()
                            {
                                this.tmrShowProgress.Stop();
                                pgbProcess.Maximum = codes.Count;
                                pgbProcess.Value = codeIndex;
                            }));

            }
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.lsvLog.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lsvLog.View = View.Details;
            this.lsvLog.Columns.Add("时间");
            this.lsvLog.Columns.Add("操作");
            this.lsvLog.Columns.Add("详细");
            this.lsvLog.Columns[1].Width = 280;
            this.lsvLog.Columns[2].Width = 220;
        }

        private void AddLog(string Message)
        {
            AddLog(Message, null);
        }
        private void AddLog(string Message, Exception ex)
        {
            if (InvokeRequired)
            {
                this.lsvLog.BeginInvoke(new MethodInvoker(delegate()
                {
                    this.lsvLog.Items.Add(new ListViewItem(new string[]{
                                                DateTime .Now .ToString ("hh:mm:ss"),
                                                Message ,
                                                (ex!= null )?  ex.ToString () :""}));

                }));
            }
            else
            {
                this.lsvLog.Items.Add(new ListViewItem(new string[]{
                                                DateTime .Now .ToString ("hh:mm:ss"),
                                                Message ,
                                                (ex!= null )?  ex.ToString () :""}));
            }
        }

        private void tmrShowProgress_Tick(object sender, EventArgs e)
        {
            pgbProcess.Maximum = (codes.Count > 100) ? (codes.Count) : (100);
            pgbProcess.Value = codeIndex;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            UserSetPasue = !UserSetPasue;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            UserSetExit = true;
        }
    }
}
