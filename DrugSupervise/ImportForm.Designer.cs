namespace DrugSupervise.Demo
{
    partial class ImportForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvLog = new System.Windows.Forms.ListView();
            this.tmrShowProgress = new System.Windows.Forms.Timer(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(29, 33);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(161, 12);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "请指定要导入的药监码文件：";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(31, 61);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(459, 21);
            this.txtFile.TabIndex = 1;
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(516, 55);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(96, 30);
            this.cmdOpen.TabIndex = 2;
            this.cmdOpen.Text = "打开(&O)...";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // pgbProcess
            // 
            this.pgbProcess.Location = new System.Drawing.Point(33, 141);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(457, 18);
            this.pgbProcess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前进度：";
            // 
            // lsvLog
            // 
            this.lsvLog.FullRowSelect = true;
            this.lsvLog.Location = new System.Drawing.Point(31, 182);
            this.lsvLog.MultiSelect = false;
            this.lsvLog.Name = "lsvLog";
            this.lsvLog.Size = new System.Drawing.Size(580, 194);
            this.lsvLog.TabIndex = 5;
            this.lsvLog.UseCompatibleStateImageBehavior = false;
            this.lsvLog.View = System.Windows.Forms.View.Details;
            // 
            // tmrShowProgress
            // 
            this.tmrShowProgress.Interval = 1000;
            this.tmrShowProgress.Tick += new System.EventHandler(this.tmrShowProgress_Tick);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(575, 124);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(53, 35);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(516, 124);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 35);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 391);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.lsvLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbProcess);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.Text = "药监码导入－DEMO";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.ProgressBar pgbProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvLog;
        private System.Windows.Forms.Timer tmrShowProgress;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnPause;
    }
}

