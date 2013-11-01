namespace DrugSupervise.Demo
{
    partial class ScannerForm
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
            this.lsvCodes = new System.Windows.Forms.ListView();
            this.btnFit = new System.Windows.Forms.Button();
            this.btnSendPL1 = new System.Windows.Forms.Button();
            this.cmbPortF = new System.Windows.Forms.ComboBox();
            this.btnSendPL2 = new System.Windows.Forms.Button();
            this.cmbPortS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsvCodes
            // 
            this.lsvCodes.FullRowSelect = true;
            this.lsvCodes.Location = new System.Drawing.Point(12, 12);
            this.lsvCodes.MultiSelect = false;
            this.lsvCodes.Name = "lsvCodes";
            this.lsvCodes.Size = new System.Drawing.Size(204, 380);
            this.lsvCodes.TabIndex = 6;
            this.lsvCodes.UseCompatibleStateImageBehavior = false;
            this.lsvCodes.View = System.Windows.Forms.View.Details;
            // 
            // btnFit
            // 
            this.btnFit.Location = new System.Drawing.Point(239, 34);
            this.btnFit.Name = "btnFit";
            this.btnFit.Size = new System.Drawing.Size(114, 41);
            this.btnFit.TabIndex = 7;
            this.btnFit.Text = "准备条码(&F)";
            this.btnFit.UseVisualStyleBackColor = true;
            this.btnFit.Click += new System.EventHandler(this.btnFit_Click);
            // 
            // btnSendPL1
            // 
            this.btnSendPL1.Location = new System.Drawing.Point(239, 148);
            this.btnSendPL1.Name = "btnSendPL1";
            this.btnSendPL1.Size = new System.Drawing.Size(114, 41);
            this.btnSendPL1.TabIndex = 8;
            this.btnSendPL1.Text = "发送一级码(&F)";
            this.btnSendPL1.UseVisualStyleBackColor = true;
            this.btnSendPL1.Click += new System.EventHandler(this.btnSendPL1_Click);
            // 
            // cmbPortF
            // 
            this.cmbPortF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortF.FormattingEnabled = true;
            this.cmbPortF.Location = new System.Drawing.Point(239, 122);
            this.cmbPortF.Name = "cmbPortF";
            this.cmbPortF.Size = new System.Drawing.Size(89, 20);
            this.cmbPortF.TabIndex = 9;
            // 
            // btnSendPL2
            // 
            this.btnSendPL2.Location = new System.Drawing.Point(239, 278);
            this.btnSendPL2.Name = "btnSendPL2";
            this.btnSendPL2.Size = new System.Drawing.Size(114, 41);
            this.btnSendPL2.TabIndex = 11;
            this.btnSendPL2.Text = "发送二级码(&S)";
            this.btnSendPL2.UseVisualStyleBackColor = true;
            this.btnSendPL2.Click += new System.EventHandler(this.btnSendPL2_Click);
            // 
            // cmbPortS
            // 
            this.cmbPortS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortS.FormattingEnabled = true;
            this.cmbPortS.Location = new System.Drawing.Point(239, 252);
            this.cmbPortS.Name = "cmbPortS";
            this.cmbPortS.Size = new System.Drawing.Size(89, 20);
            this.cmbPortS.TabIndex = 12;
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 404);
            this.Controls.Add(this.cmbPortS);
            this.Controls.Add(this.btnSendPL2);
            this.Controls.Add(this.cmbPortF);
            this.Controls.Add(this.btnSendPL1);
            this.Controls.Add(this.btnFit);
            this.Controls.Add(this.lsvCodes);
            this.MaximizeBox = false;
            this.Name = "ScannerForm";
            this.Text = "虚拟条码扫描";
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvCodes;
        private System.Windows.Forms.Button btnFit;
        private System.Windows.Forms.Button btnSendPL1;
        private System.Windows.Forms.ComboBox cmbPortF;
        private System.Windows.Forms.Button btnSendPL2;
        private System.Windows.Forms.ComboBox cmbPortS;
    }
}