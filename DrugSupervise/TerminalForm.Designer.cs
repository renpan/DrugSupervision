namespace DrugSupervise.Demo
{
    partial class TerminalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sspStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbPackRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trvPackes = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPackMode = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbPort1st = new System.Windows.Forms.ComboBox();
            this.cmbPort2nd = new System.Windows.Forms.ComboBox();
            this.cmbPort3rd = new System.Windows.Forms.ComboBox();
            this.sspStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspStatus
            // 
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.sspStatus.Location = new System.Drawing.Point(0, 402);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(625, 26);
            this.sspStatus.TabIndex = 0;
            this.sspStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 21);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 21);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(200, 21);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // cmbPackRate
            // 
            this.cmbPackRate.FormattingEnabled = true;
            this.cmbPackRate.Items.AddRange(new object[] {
            "1:2",
            "1:3",
            "1:5",
            "1:10",
            "1:2:10",
            "1:3:15",
            "1:5:20",
            "1:10:50"});
            this.cmbPackRate.Location = new System.Drawing.Point(414, 74);
            this.cmbPackRate.Name = "cmbPackRate";
            this.cmbPackRate.Size = new System.Drawing.Size(119, 20);
            this.cmbPackRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "包装比例";
            // 
            // trvPackes
            // 
            this.trvPackes.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvPackes.Location = new System.Drawing.Point(0, 0);
            this.trvPackes.Name = "trvPackes";
            this.trvPackes.Size = new System.Drawing.Size(267, 402);
            this.trvPackes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "包装模式";
            // 
            // cmbPackMode
            // 
            this.cmbPackMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackMode.FormattingEnabled = true;
            this.cmbPackMode.Items.AddRange(new object[] {
            "0－正常",
            "1－拼箱",
            "2－零箱",
            "3－拼箱又零箱"});
            this.cmbPackMode.Location = new System.Drawing.Point(414, 110);
            this.cmbPackMode.Name = "cmbPackMode";
            this.cmbPackMode.Size = new System.Drawing.Size(119, 20);
            this.cmbPackMode.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 82);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbPort1st
            // 
            this.cmbPort1st.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort1st.FormattingEnabled = true;
            this.cmbPort1st.Location = new System.Drawing.Point(357, 342);
            this.cmbPort1st.Name = "cmbPort1st";
            this.cmbPort1st.Size = new System.Drawing.Size(62, 20);
            this.cmbPort1st.TabIndex = 10;
            // 
            // cmbPort2nd
            // 
            this.cmbPort2nd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort2nd.FormattingEnabled = true;
            this.cmbPort2nd.Location = new System.Drawing.Point(440, 342);
            this.cmbPort2nd.Name = "cmbPort2nd";
            this.cmbPort2nd.Size = new System.Drawing.Size(62, 20);
            this.cmbPort2nd.TabIndex = 11;
            // 
            // cmbPort3rd
            // 
            this.cmbPort3rd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort3rd.FormattingEnabled = true;
            this.cmbPort3rd.Location = new System.Drawing.Point(519, 342);
            this.cmbPort3rd.Name = "cmbPort3rd";
            this.cmbPort3rd.Size = new System.Drawing.Size(62, 20);
            this.cmbPort3rd.TabIndex = 12;
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.cmbPort3rd);
            this.Controls.Add(this.cmbPort2nd);
            this.Controls.Add(this.cmbPort1st);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbPackMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trvPackes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPackRate);
            this.Controls.Add(this.sspStatus);
            this.MaximizeBox = false;
            this.Name = "TerminalForm";
            this.Text = "赋码终端Demo";
            this.Load += new System.EventHandler(this.TerminalForm_Load);
            this.sspStatus.ResumeLayout(false);
            this.sspStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sspStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ComboBox cmbPackRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvPackes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPackMode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbPort1st;
        private System.Windows.Forms.ComboBox cmbPort2nd;
        private System.Windows.Forms.ComboBox cmbPort3rd;
    }
}