using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;

namespace DrugSupervise.Demo
{
    public partial class ScannerForm : Form
    {
        struct DrugCode
        {
            public string Code;
            public int PackLevel;
            public DrugCode(string code, int level)
            {
                Code = code;
                PackLevel = level;
            }
        }
        List<DrugCode> codes;
        public ScannerForm()
        {
            InitializeComponent();
            codes = new List<DrugCode>();
        }

        private void btnFit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(
                   "server=192.168.1.200;database=Test;uid=Test;pwd=test;charset=utf8;");
            DataTable result;
            MySqlDataAdapter dataAdapter;
            try
            {
                connection.Open();
                result = new DataTable("Result-10 Barcode");
                dataAdapter = new MySqlDataAdapter(
                    "(SELECT barcode,packLevel FROM packing WHERE state=1 AND packlevel = 1 limit 0,30)  UNION ( SELECT barcode,packLevel FROM packing WHERE state=1 AND packlevel = 2 limit 0,5)"
                    , connection);

                dataAdapter.Fill(result);
                foreach (DataRow row in result.Rows)
                {
                    codes.Add(
                        new DrugCode(
                                row["barcode"].ToString(),
                                 int.Parse(row["packLevel"].ToString())
                                    )
                            );
                }

                foreach (DrugCode code in codes)
                {
                    lsvCodes.Items.Add(new ListViewItem(new string[] { code.Code, code.PackLevel.ToString() }));

                    MySqlCommand command = new MySqlCommand(
                            string.Format("UPDATE packing SET state=3 WHERE barcode='{0}'", code.Code), connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

        }
        SerialPort port = null;
        private void ScannerForm_Load(object sender, EventArgs e)
        {
            this.lsvCodes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lsvCodes.View = View.Details;
            this.lsvCodes.Columns.Add("条码");
            this.lsvCodes.Columns.Add("级别");
            this.lsvCodes.Columns[0].Width = 150;
            string[] ports = SerialPort.GetPortNames();

            foreach (string portName in ports)
            {
                this.cmbPortF.Items.Add(portName);
                this.cmbPortS.Items.Add(portName);
            }
            if (cmbPortF.Items.Count >= 5)
            {
                cmbPortF.SelectedIndex = 1;
                cmbPortS.SelectedIndex = 3;

            }
        }




        private void sendCode(string portName, string code)
        {
            if ((codes.Count <= 0) || (portName == string.Empty)) return;
            if (port != null)
            {
                if (port.IsOpen) port.Close();
                port.Dispose();
            }

            port = new SerialPort(portName, 9600);
            port.Open();

            port.Write(code + (char)13 + (char)10);

            lsvCodes.Items.Clear();
            foreach (DrugCode c in codes)
            {
                lsvCodes.Items.Add(new ListViewItem(new string[] { c.Code, c.PackLevel.ToString() }));
            }
        }

        private void btnSendPL1_Click(object sender, EventArgs e)
        {
            var c = from code in codes
                    where code.PackLevel == 1
                    select code;
            if (c.Count() <= 0) return;
            DrugCode fc = c.First();
            codes.Remove(fc);
            sendCode(this.cmbPortF.Text, fc.Code);
        }

        private void btnSendPL2_Click(object sender, EventArgs e)
        {
            var c = from code in codes
                    where code.PackLevel == 2
                    select code;
            if (c.Count() <= 0) return;
            DrugCode fc = c.First();
            codes.Remove(fc);
            sendCode(this.cmbPortS.Text, fc.Code);
        }
    }
}
