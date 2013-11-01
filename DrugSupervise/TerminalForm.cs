using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using DrugSupervise.Library;

namespace DrugSupervise.Demo
{
    public partial class TerminalForm : Form
    {
        public TerminalForm()
        {
            InitializeComponent();
            ports = new Dictionary<string, SerialPort>();
        }
        DrugPacks packs;
        Dictionary<string, SerialPort> ports;
        //Dictionary<int, int> codeCounter;
        //PackRate rate = new PackRate("1:2:10");
        private void TerminalForm_Load(object sender, EventArgs e)
        {
            ports.Add("1st", new SerialPort());
            ports.Add("2nd", new SerialPort());
            ports.Add("3rd", new SerialPort());

            string[] portsName = SerialPort.GetPortNames();
            foreach (string portName in portsName)
            {
                this.cmbPort1st.Items.Add(portName);
                this.cmbPort2nd.Items.Add(portName);
                this.cmbPort3rd.Items.Add(portName);
            }

            if (portsName.Length >= 5)
            {
                this.cmbPort1st.SelectedIndex = 2;
                this.cmbPort2nd.SelectedIndex = 4;
            }

            this.cmbPackRate.SelectedIndex = 1;
            this.cmbPackMode.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;

            packs = new DrugPacks(new PackRate(this.cmbPackRate.Text));

            #region 准备串行端口
            if (this.cmbPort1st.Text != string.Empty) ports["1st"].PortName = this.cmbPort1st.Text;
            if (this.cmbPort2nd.Text != string.Empty) ports["2nd"].PortName = this.cmbPort2nd.Text;
            if (this.cmbPort3rd.Text != string.Empty) ports["3rd"].PortName = this.cmbPort3rd.Text;
            foreach (SerialPort port in ports.Values)
            {
                if (port.PortName != string.Empty)
                {
                    port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                    port.Open();
                }
            }
            #endregion
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            int layer = 0;
            if (port.PortName == ports["1st"].PortName) layer = 0;
            if (port.PortName == ports["2nd"].PortName) layer = 1;
            if (port.PortName == ports["3rd"].PortName) layer = 2;

            string code = port.ReadLine();

            var result = from box in packs[layer]
                         where !box.HasBarcode
                         select box;
            if (result.Count() > 0)
            { result.First().Barcode = code; }
            else
            {
                if (layer > 0)
                    MessageBox.Show(string.Format("尚不存在需要赋码的{0}级包装，不准提前赋码！", layer + 1));
                else
                    packs.Add(layer, new DrugBox(code, layer));
            }





            this.BeginInvoke(new MethodInvoker(
                delegate
                {
                    ShowPacks();
                }));
        }

        private void AddNode(TreeNode node, DrugBox drugBox)
        {
            node.Name = drugBox.Barcode;
            if (drugBox.Child != null)
                foreach (DrugBox child in drugBox.Child)
                {
                    if (child.Layer == 0)
                    {
                        node.Nodes.Add(child.Barcode);
                    }
                    else
                    {
                        AddNode(node.Nodes.Add(child.Barcode), child);
                    }
                }
        }
        private void ShowPacks()
        {
            trvPackes.Nodes.Clear();
            foreach (DrugBox box in packs[packs.Level - 1])
            {
                TreeNode newNode = this.trvPackes.Nodes.Add(box.Barcode);
                AddNode(newNode, box);

            }
            foreach (TreeNode node in trvPackes.Nodes)
            {
                node.ExpandAll();
            }
        }

    }
}
