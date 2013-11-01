namespace DrugSupervise.Demo
{
    partial class MainForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(52, 35);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 86);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "导入监管码(&I)";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnScanner
            // 
            this.btnScanner.Location = new System.Drawing.Point(189, 35);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(110, 86);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.Text = "模拟扫码器(&S)";
            this.btnScanner.UseVisualStyleBackColor = true;
            // 
            // btnTerminal
            // 
            this.btnTerminal.Location = new System.Drawing.Point(326, 35);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(110, 86);
            this.btnTerminal.TabIndex = 2;
            this.btnTerminal.Text = "赋码终端(&T)";
            this.btnTerminal.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(463, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 86);
            this.button4.TabIndex = 3;
            this.button4.Text = "未使用";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(600, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 86);
            this.button5.TabIndex = 4;
            this.button5.Text = "未使用";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 162);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTerminal);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品蓝管码赋码系统Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}