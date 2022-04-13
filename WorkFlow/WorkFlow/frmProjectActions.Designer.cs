namespace WorkFlow
{
    partial class frmProjectActions
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
            this.cmbActiveProjects = new System.Windows.Forms.ComboBox();
            this.dgrTaskActions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTask = new System.Windows.Forms.Panel();
            this.hScrlStat = new System.Windows.Forms.HScrollBar();
            this.prgBarSituation = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTaskUsers = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmFinshDt = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDt = new System.Windows.Forms.DateTimePicker();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.rdBtnRemars = new System.Windows.Forms.RadioButton();
            this.rdBtnTask = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaskActions)).BeginInit();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbActiveProjects
            // 
            this.cmbActiveProjects.FormattingEnabled = true;
            this.cmbActiveProjects.Location = new System.Drawing.Point(209, 205);
            this.cmbActiveProjects.Name = "cmbActiveProjects";
            this.cmbActiveProjects.Size = new System.Drawing.Size(121, 21);
            this.cmbActiveProjects.TabIndex = 0;
            this.cmbActiveProjects.SelectedIndexChanged += new System.EventHandler(this.cmbActiveProjects_SelectedIndexChanged);
            // 
            // dgrTaskActions
            // 
            this.dgrTaskActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTaskActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrTaskActions.Location = new System.Drawing.Point(0, 232);
            this.dgrTaskActions.Name = "dgrTaskActions";
            this.dgrTaskActions.Size = new System.Drawing.Size(871, 247);
            this.dgrTaskActions.TabIndex = 1;
            this.dgrTaskActions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTaskActions_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Project";
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.hScrlStat);
            this.panelTask.Controls.Add(this.prgBarSituation);
            this.panelTask.Controls.Add(this.label6);
            this.panelTask.Controls.Add(this.label5);
            this.panelTask.Controls.Add(this.cmbTaskUsers);
            this.panelTask.Controls.Add(this.btnAddTask);
            this.panelTask.Controls.Add(this.label4);
            this.panelTask.Controls.Add(this.label3);
            this.panelTask.Controls.Add(this.label2);
            this.panelTask.Controls.Add(this.dtmFinshDt);
            this.panelTask.Controls.Add(this.dtmStartDt);
            this.panelTask.Controls.Add(this.txtTaskName);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(871, 196);
            this.panelTask.TabIndex = 3;
            // 
            // hScrlStat
            // 
            this.hScrlStat.Location = new System.Drawing.Point(195, 148);
            this.hScrlStat.Name = "hScrlStat";
            this.hScrlStat.Size = new System.Drawing.Size(661, 19);
            this.hScrlStat.TabIndex = 11;
            // 
            // prgBarSituation
            // 
            this.prgBarSituation.Location = new System.Drawing.Point(195, 121);
            this.prgBarSituation.Name = "prgBarSituation";
            this.prgBarSituation.Size = new System.Drawing.Size(661, 23);
            this.prgBarSituation.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Double Click here for returning to previous screen!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Task Users:";
            // 
            // cmbTaskUsers
            // 
            this.cmbTaskUsers.FormattingEnabled = true;
            this.cmbTaskUsers.Location = new System.Drawing.Point(83, 121);
            this.cmbTaskUsers.Name = "cmbTaskUsers";
            this.cmbTaskUsers.Size = new System.Drawing.Size(106, 21);
            this.cmbTaskUsers.TabIndex = 8;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(751, 170);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(108, 23);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add/Update Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Finish Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name:";
            // 
            // dtmFinshDt
            // 
            this.dtmFinshDt.Location = new System.Drawing.Point(662, 90);
            this.dtmFinshDt.Name = "dtmFinshDt";
            this.dtmFinshDt.Size = new System.Drawing.Size(200, 20);
            this.dtmFinshDt.TabIndex = 2;
            // 
            // dtmStartDt
            // 
            this.dtmStartDt.Location = new System.Drawing.Point(390, 90);
            this.dtmStartDt.Name = "dtmStartDt";
            this.dtmStartDt.Size = new System.Drawing.Size(200, 20);
            this.dtmStartDt.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(87, 90);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(228, 20);
            this.txtTaskName.TabIndex = 0;
            // 
            // rdBtnRemars
            // 
            this.rdBtnRemars.AutoSize = true;
            this.rdBtnRemars.Location = new System.Drawing.Point(544, 209);
            this.rdBtnRemars.Name = "rdBtnRemars";
            this.rdBtnRemars.Size = new System.Drawing.Size(94, 17);
            this.rdBtnRemars.TabIndex = 4;
            this.rdBtnRemars.TabStop = true;
            this.rdBtnRemars.Text = "Task Remarks";
            this.rdBtnRemars.UseVisualStyleBackColor = true;
            this.rdBtnRemars.CheckedChanged += new System.EventHandler(this.rdBtnRemars_CheckedChanged);
            // 
            // rdBtnTask
            // 
            this.rdBtnTask.AutoSize = true;
            this.rdBtnTask.Location = new System.Drawing.Point(428, 209);
            this.rdBtnTask.Name = "rdBtnTask";
            this.rdBtnTask.Size = new System.Drawing.Size(54, 17);
            this.rdBtnTask.TabIndex = 5;
            this.rdBtnTask.TabStop = true;
            this.rdBtnTask.Text = "Tasks";
            this.rdBtnTask.UseVisualStyleBackColor = true;
            this.rdBtnTask.CheckedChanged += new System.EventHandler(this.rdBtnTask_CheckedChanged);
            // 
            // frmProjectActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 479);
            this.Controls.Add(this.rdBtnTask);
            this.Controls.Add(this.rdBtnRemars);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrTaskActions);
            this.Controls.Add(this.cmbActiveProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjectActions";
            this.Text = "Project Actions";
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaskActions)).EndInit();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActiveProjects;
        private System.Windows.Forms.DataGridView dgrTaskActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.RadioButton rdBtnRemars;
        private System.Windows.Forms.RadioButton rdBtnTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmFinshDt;
        private System.Windows.Forms.DateTimePicker dtmStartDt;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTaskUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar prgBarSituation;
        private System.Windows.Forms.HScrollBar hScrlStat;
    }
}