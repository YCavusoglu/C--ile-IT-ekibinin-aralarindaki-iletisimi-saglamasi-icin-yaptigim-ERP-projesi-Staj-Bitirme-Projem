namespace WorkFlow
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMyView = new System.Windows.Forms.TabPage();
            this.dgrMyView = new System.Windows.Forms.DataGridView();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReportUsr = new System.Windows.Forms.ComboBox();
            this.dgrReport = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpMyView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMyView)).BeginInit();
            this.tpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMyView);
            this.tabControl1.Controls.Add(this.tpReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMyView
            // 
            this.tpMyView.Controls.Add(this.dgrMyView);
            this.tpMyView.Location = new System.Drawing.Point(4, 22);
            this.tpMyView.Name = "tpMyView";
            this.tpMyView.Padding = new System.Windows.Forms.Padding(3);
            this.tpMyView.Size = new System.Drawing.Size(907, 463);
            this.tpMyView.TabIndex = 0;
            this.tpMyView.Text = "My View";
            this.tpMyView.UseVisualStyleBackColor = true;
            // 
            // dgrMyView
            // 
            this.dgrMyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrMyView.Location = new System.Drawing.Point(3, 3);
            this.dgrMyView.Name = "dgrMyView";
            this.dgrMyView.Size = new System.Drawing.Size(901, 457);
            this.dgrMyView.TabIndex = 2;
            this.dgrMyView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgrMyView_MouseClick);
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.label1);
            this.tpReport.Controls.Add(this.cmbReportUsr);
            this.tpReport.Controls.Add(this.dgrReport);
            this.tpReport.Location = new System.Drawing.Point(4, 22);
            this.tpReport.Name = "tpReport";
            this.tpReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpReport.Size = new System.Drawing.Size(907, 463);
            this.tpReport.TabIndex = 1;
            this.tpReport.Text = "Report";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select User For Report:";
            // 
            // cmbReportUsr
            // 
            this.cmbReportUsr.FormattingEnabled = true;
            this.cmbReportUsr.Location = new System.Drawing.Point(226, 3);
            this.cmbReportUsr.Name = "cmbReportUsr";
            this.cmbReportUsr.Size = new System.Drawing.Size(121, 21);
            this.cmbReportUsr.TabIndex = 1;
            this.cmbReportUsr.SelectedIndexChanged += new System.EventHandler(this.cmbReportUsr_SelectedIndexChanged);
            // 
            // dgrReport
            // 
            this.dgrReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrReport.Location = new System.Drawing.Point(0, 24);
            this.dgrReport.Name = "dgrReport";
            this.dgrReport.Size = new System.Drawing.Size(907, 439);
            this.dgrReport.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Workflow Projects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpMyView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMyView)).EndInit();
            this.tpReport.ResumeLayout(false);
            this.tpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMyView;
        private System.Windows.Forms.DataGridView dgrMyView;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReportUsr;
        private System.Windows.Forms.DataGridView dgrReport;
    }
}

