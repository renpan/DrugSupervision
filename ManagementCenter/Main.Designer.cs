namespace ManagementCenter
{
    partial class Main
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
            this.fmsCode = new OpenSource.PhhSoft.FoldingMenuStrip();
            this.fmiBasicInformation = new OpenSource.PhhSoft.Support.FoldingMenuItem();
            this.btnDrugInfo = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.btnDrugBatch = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.fmiProductionManagement = new OpenSource.PhhSoft.Support.FoldingMenuItem();
            this.btnTask = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.btnCodeGather = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.fmiExceptionManagement = new OpenSource.PhhSoft.Support.FoldingMenuItem();
            this.btnPackageScattered = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.btnPackageIntegrated = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.foldingMenuItem1 = new OpenSource.PhhSoft.Support.FoldingMenuItem();
            this.btnDrugCode = new OpenSource.PhhSoft.Support.FoldingButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fmsCode.SuspendLayout();
            this.fmiBasicInformation.InnerPanel.SuspendLayout();
            this.fmiProductionManagement.InnerPanel.SuspendLayout();
            this.fmiExceptionManagement.InnerPanel.SuspendLayout();
            this.foldingMenuItem1.InnerPanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fmsCode
            // 
            this.fmsCode.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.fmsCode.AItems.AddRange(new OpenSource.PhhSoft.Support.FoldingMenuItem[] {
            this.fmiBasicInformation,
            this.fmiProductionManagement,
            this.fmiExceptionManagement,
            this.foldingMenuItem1});
            this.fmsCode.Controls.Add(this.fmiExceptionManagement);
            this.fmsCode.Controls.Add(this.fmiProductionManagement);
            this.fmsCode.Controls.Add(this.fmiBasicInformation);
            this.fmsCode.Controls.Add(this.foldingMenuItem1);
            this.fmsCode.CurrentItem = this.fmiBasicInformation;
            this.fmsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsCode.Location = new System.Drawing.Point(0, 0);
            this.fmsCode.Name = "fmsCode";
            this.fmsCode.Size = new System.Drawing.Size(150, 446);
            this.fmsCode.TabIndex = 0;
            this.fmsCode.Text = "系统配置";
            // 
            // fmiBasicInformation
            // 
            this.fmiBasicInformation.ButtonItems.AddRange(new OpenSource.PhhSoft.Support.FoldingButtonItem[] {
            this.btnDrugInfo,
            this.btnDrugBatch});
            // 
            // 
            // 
            this.fmiBasicInformation.InnerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fmiBasicInformation.InnerPanel.Controls.Add(this.btnDrugInfo);
            this.fmiBasicInformation.InnerPanel.Controls.Add(this.btnDrugBatch);
            this.fmiBasicInformation.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmiBasicInformation.InnerPanel.Location = new System.Drawing.Point(1, 30);
            this.fmiBasicInformation.InnerPanel.Name = "panel1";
            this.fmiBasicInformation.InnerPanel.Size = new System.Drawing.Size(148, 52);
            this.fmiBasicInformation.InnerPanel.TabIndex = 0;
            this.fmiBasicInformation.IsOpened = true;
            this.fmiBasicInformation.Location = new System.Drawing.Point(0, 0);
            this.fmiBasicInformation.Margin = new System.Windows.Forms.Padding(1);
            this.fmiBasicInformation.Name = "fmiBasicInformation";
            this.fmiBasicInformation.Padding = new System.Windows.Forms.Padding(1, 30, 1, 0);
            this.fmiBasicInformation.Size = new System.Drawing.Size(150, 82);
            this.fmiBasicInformation.TabIndex = 0;
            this.fmiBasicInformation.TabStop = false;
            this.fmiBasicInformation.Text = "基础数据";
            // 
            // btnDrugInfo
            // 
            this.btnDrugInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrugInfo.Location = new System.Drawing.Point(0, 0);
            this.btnDrugInfo.Name = "btnDrugInfo";
            this.btnDrugInfo.Size = new System.Drawing.Size(148, 26);
            this.btnDrugInfo.TabIndex = 0;
            this.btnDrugInfo.Text = "药品信息";
            this.btnDrugInfo.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // btnDrugBatch
            // 
            this.btnDrugBatch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDrugBatch.Location = new System.Drawing.Point(0, 26);
            this.btnDrugBatch.Name = "btnDrugBatch";
            this.btnDrugBatch.Size = new System.Drawing.Size(148, 26);
            this.btnDrugBatch.TabIndex = 1;
            this.btnDrugBatch.Text = "药品批次";
            this.btnDrugBatch.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // fmiProductionManagement
            // 
            this.fmiProductionManagement.ButtonItems.AddRange(new OpenSource.PhhSoft.Support.FoldingButtonItem[] {
            this.btnTask,
            this.btnCodeGather});
            // 
            // 
            // 
            this.fmiProductionManagement.InnerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fmiProductionManagement.InnerPanel.Controls.Add(this.btnTask);
            this.fmiProductionManagement.InnerPanel.Controls.Add(this.btnCodeGather);
            this.fmiProductionManagement.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmiProductionManagement.InnerPanel.Location = new System.Drawing.Point(1, 30);
            this.fmiProductionManagement.InnerPanel.Name = "panel1";
            this.fmiProductionManagement.InnerPanel.Size = new System.Drawing.Size(148, 0);
            this.fmiProductionManagement.InnerPanel.TabIndex = 0;
            this.fmiProductionManagement.IsOpened = false;
            this.fmiProductionManagement.Location = new System.Drawing.Point(0, 358);
            this.fmiProductionManagement.Margin = new System.Windows.Forms.Padding(1);
            this.fmiProductionManagement.Name = "fmiProductionManagement";
            this.fmiProductionManagement.Padding = new System.Windows.Forms.Padding(1, 30, 1, 0);
            this.fmiProductionManagement.Size = new System.Drawing.Size(150, 30);
            this.fmiProductionManagement.TabIndex = 1;
            this.fmiProductionManagement.TabStop = false;
            this.fmiProductionManagement.Text = "生产管理";
            // 
            // btnTask
            // 
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTask.Location = new System.Drawing.Point(0, 0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(148, 26);
            this.btnTask.TabIndex = 0;
            this.btnTask.Text = "生产任务";
            this.btnTask.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // btnCodeGather
            // 
            this.btnCodeGather.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCodeGather.Location = new System.Drawing.Point(0, -26);
            this.btnCodeGather.Name = "btnCodeGather";
            this.btnCodeGather.Size = new System.Drawing.Size(148, 26);
            this.btnCodeGather.TabIndex = 1;
            this.btnCodeGather.Text = "包装赋码";
            this.btnCodeGather.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // fmiExceptionManagement
            // 
            this.fmiExceptionManagement.ButtonItems.AddRange(new OpenSource.PhhSoft.Support.FoldingButtonItem[] {
            this.btnPackageScattered,
            this.btnPackageIntegrated});
            // 
            // 
            // 
            this.fmiExceptionManagement.InnerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fmiExceptionManagement.InnerPanel.Controls.Add(this.btnPackageScattered);
            this.fmiExceptionManagement.InnerPanel.Controls.Add(this.btnPackageIntegrated);
            this.fmiExceptionManagement.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmiExceptionManagement.InnerPanel.Location = new System.Drawing.Point(1, 30);
            this.fmiExceptionManagement.InnerPanel.Name = "panel1";
            this.fmiExceptionManagement.InnerPanel.Size = new System.Drawing.Size(148, 0);
            this.fmiExceptionManagement.InnerPanel.TabIndex = 0;
            this.fmiExceptionManagement.IsOpened = false;
            this.fmiExceptionManagement.Location = new System.Drawing.Point(0, 387);
            this.fmiExceptionManagement.Margin = new System.Windows.Forms.Padding(1);
            this.fmiExceptionManagement.Name = "fmiExceptionManagement";
            this.fmiExceptionManagement.Padding = new System.Windows.Forms.Padding(1, 30, 1, 0);
            this.fmiExceptionManagement.Size = new System.Drawing.Size(150, 30);
            this.fmiExceptionManagement.TabIndex = 2;
            this.fmiExceptionManagement.TabStop = false;
            this.fmiExceptionManagement.Text = "异常管理";
            // 
            // btnPackageScattered
            // 
            this.btnPackageScattered.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPackageScattered.Location = new System.Drawing.Point(0, 0);
            this.btnPackageScattered.Name = "btnPackageScattered";
            this.btnPackageScattered.Size = new System.Drawing.Size(148, 26);
            this.btnPackageScattered.TabIndex = 0;
            this.btnPackageScattered.Text = "包装零箱";
            this.btnPackageScattered.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // btnPackageIntegrated
            // 
            this.btnPackageIntegrated.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPackageIntegrated.Location = new System.Drawing.Point(0, -26);
            this.btnPackageIntegrated.Name = "btnPackageIntegrated";
            this.btnPackageIntegrated.Size = new System.Drawing.Size(148, 26);
            this.btnPackageIntegrated.TabIndex = 1;
            this.btnPackageIntegrated.Text = "包装拼箱";
            this.btnPackageIntegrated.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // foldingMenuItem1
            // 
            this.foldingMenuItem1.ButtonItems.AddRange(new OpenSource.PhhSoft.Support.FoldingButtonItem[] {
            this.btnDrugCode});
            // 
            // 
            // 
            this.foldingMenuItem1.InnerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.foldingMenuItem1.InnerPanel.Controls.Add(this.btnDrugCode);
            this.foldingMenuItem1.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foldingMenuItem1.InnerPanel.Location = new System.Drawing.Point(1, 30);
            this.foldingMenuItem1.InnerPanel.Name = "panel1";
            this.foldingMenuItem1.InnerPanel.Size = new System.Drawing.Size(148, 26);
            this.foldingMenuItem1.InnerPanel.TabIndex = 0;
            this.foldingMenuItem1.IsOpened = false;
            this.foldingMenuItem1.Location = new System.Drawing.Point(0, 416);
            this.foldingMenuItem1.Margin = new System.Windows.Forms.Padding(1);
            this.foldingMenuItem1.Name = "foldingMenuItem1";
            this.foldingMenuItem1.Padding = new System.Windows.Forms.Padding(1, 30, 1, 0);
            this.foldingMenuItem1.Size = new System.Drawing.Size(150, 30);
            this.foldingMenuItem1.TabIndex = 3;
            this.foldingMenuItem1.TabStop = false;
            this.foldingMenuItem1.Text = "药监码管理";
            // 
            // btnDrugCode
            // 
            this.btnDrugCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrugCode.Location = new System.Drawing.Point(0, 0);
            this.btnDrugCode.Name = "btnDrugCode";
            this.btnDrugCode.Size = new System.Drawing.Size(148, 26);
            this.btnDrugCode.TabIndex = 0;
            this.btnDrugCode.Text = "药监码";
            this.btnDrugCode.Click += new System.EventHandler(this.FoldingButtonItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fmsCode);
            this.splitContainer1.Panel1MinSize = 15;
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(837, 446);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 481);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Main";
            this.fmsCode.ResumeLayout(false);
            this.fmiBasicInformation.InnerPanel.ResumeLayout(false);
            this.fmiProductionManagement.InnerPanel.ResumeLayout(false);
            this.fmiExceptionManagement.InnerPanel.ResumeLayout(false);
            this.foldingMenuItem1.InnerPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenSource.PhhSoft.FoldingMenuStrip fmsCode;
        private OpenSource.PhhSoft.Support.FoldingMenuItem fmiBasicInformation;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnDrugInfo;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnDrugBatch;
        private OpenSource.PhhSoft.Support.FoldingMenuItem fmiProductionManagement;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnTask;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnCodeGather;
        private OpenSource.PhhSoft.Support.FoldingMenuItem fmiExceptionManagement;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnPackageScattered;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnPackageIntegrated;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private OpenSource.PhhSoft.Support.FoldingMenuItem foldingMenuItem1;
        private OpenSource.PhhSoft.Support.FoldingButtonItem btnDrugCode;
      
    }
}