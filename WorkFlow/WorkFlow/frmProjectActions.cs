using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlow
{
    public partial class frmProjectActions : Form
    {
        public frmProjectActions()
        {
            InitializeComponent();
        }

        SqlConnectionCL sqlAct = new SqlConnectionCL();
        bool isUpdate = false;
        string projectTaskId;


        private void rdBtnRemars_CheckedChanged(object sender, EventArgs e)
        {
            isUpdate = false;
            label4.Enabled = true;
            cmbActiveProjects.Items.Clear();
            if (rdBtnRemars.Checked)
            {
                label1.Text = "Select Task";
                label2.Text = "Write Remark:";
                label3.Text = "Remark Date:";
                dtmFinshDt.Visible = false;
                prgBarSituation.Visible = false;
                for (int i = 0; i < sqlAct.GetQuery("SELECT * FROM dbo.Tasks AS t ", "TaskName").Count; i++)
                {
                    cmbActiveProjects.Items.Add(sqlAct.GetQuery("SELECT * FROM dbo.Tasks AS t ", "TaskName")[i]);
                }
                for (int i = 0; i < sqlAct.GetQuery("SELECT * FROM dbo.Users AS u", "UserName").Count; i++)
                {
                    cmbTaskUsers.Items.Add(sqlAct.GetQuery("SELECT * FROM dbo.Users AS u", "UserName")[i]);
                }
            }
        }

        private void rdBtnTask_CheckedChanged(object sender, EventArgs e)
        {
            isUpdate = false;
            txtTaskName.Text = null;
            cmbActiveProjects.Items.Clear();
            cmbTaskUsers.Items.Clear();
            label4.Enabled = true;
            if (rdBtnTask.Checked)
            {
                label1.Text = "Select Project:";
                label2.Text = "Task Name:";
                label3.Text = "Start Date:";
                dtmFinshDt.Visible = true;
                prgBarSituation.Visible = true;
                for (int i = 0; i < sqlAct.GetQuery("SELECT * FROM dbo.Projects AS p", "ProjectName").Count; i++)
                {
                    cmbActiveProjects.Items.Add(sqlAct.GetQuery("SELECT * FROM dbo.Projects AS p", "ProjectName")[i]);
                }
                for (int i = 0; i < sqlAct.GetQuery("SELECT * FROM dbo.Users AS u", "UserName").Count; i++)
                {
                    cmbTaskUsers.Items.Add(sqlAct.GetQuery("SELECT * FROM dbo.Users AS u", "UserName")[i]);
                }
            }
        }

        private void cmbActiveProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            isUpdate = false;
            txtTaskName.Text = null;
            if (rdBtnTask.Checked)
            {
                projectTaskId = sqlAct.GetQuery("SELECT * FROM dbo.Projects AS p WHERE p.ProjectName='" + cmbActiveProjects.SelectedItem.ToString() + "'", "ProjectID")[0].ToString();
                dgrTaskActions.DataSource = sqlAct.BindGrid("SELECT * FROM dbo.Tasks AS t WHERE t.ProjectID='" + projectTaskId + "'").Tables[0];
            }
            else
            {
                projectTaskId = sqlAct.GetQuery("SELECT * FROM dbo.Tasks AS t WHERE t.TaskName='" + cmbActiveProjects.SelectedItem.ToString() + "'", "TaskID")[0].ToString();
                dgrTaskActions.DataSource = sqlAct.BindGrid("SELECT * FROM dbo.TaskRemarks AS tr WHERE tr.TaskID='" + projectTaskId + "'").Tables[0];
            }
        }

        private void dgrTaskActions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isUpdate = true;
            DataGridViewRow dgrv = dgrTaskActions.Rows[e.RowIndex];
            if (rdBtnTask.Checked)
            {
                txtTaskName.Text = dgrv.Cells[1].Value.ToString();
                dtmStartDt.Value = string.IsNullOrEmpty(dgrv.Cells[3].Value.ToString()) ? DateTime.Now : Convert.ToDateTime(dgrv.Cells[3].Value);
                dtmFinshDt.Value = string.IsNullOrEmpty(dgrv.Cells[4].Value.ToString()) ? DateTime.Now : Convert.ToDateTime(dgrv.Cells[4].Value);
                prgBarSituation.Value = Convert.ToInt16(dgrv.Cells[5].Value);
            }
            else
            {
                txtTaskName.Text = dgrv.Cells[2].Value.ToString();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (isUpdate == true)
            {
                string answer = "";
                answer = MessageBox.Show("Are you sure to update this record?", "Update Warning", MessageBoxButtons.YesNo).ToString();
                if (answer == "Yes" && rdBtnTask.Checked)
                {
                    sqlAct.InsertToTables("UPDATE t SET t.TaskName='" + txtTaskName.Text + "',t.TaskFinishDate='" + dtmFinshDt.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',t.TaskProcess='" + hScrlStat.Value.ToString() + "' FROM dbo.Tasks AS t WHERE t.TaskID='" + projectTaskId + "'");
                    MessageBox.Show("Updated!");
                }
                else if (answer == "Yes" && rdBtnRemars.Checked)
                {
                    string getTaskUsr = (sqlAct.GetQuery("SELECT u.UserID FROM dbo.Users AS u WHERE u.UserName='" + cmbTaskUsers.SelectedItem.ToString() + "'", "UserID")[0]).ToString();
                    sqlAct.InsertToTables("UPDATE tr SET Remarks='" + txtTaskName.Text + "',UserID='" + getTaskUsr + "' FROM dbo.TaskRemarks AS tr WHERE tr.TaskID='" + projectTaskId + "'");
                    MessageBox.Show("Updated!");
                }
            }
            else
            {
                if (rdBtnTask.Checked)
                {
                    sqlAct.InsertToTables("INSERT INTO dbo.Tasks ( TaskName ,  ProjectID ,TaskStartDate , TaskFinishDate ,TaskProcess , Stat) VALUES  ('" + txtTaskName.Text + "','" + projectTaskId + "','" + dtmStartDt.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + dtmFinshDt.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',0,0)");
                    MessageBox.Show("Inserted!");
                }
                else
                {
                    string getTaskUsr = (sqlAct.GetQuery("SELECT u.UserID FROM dbo.Users AS u WHERE u.UserName='" + cmbTaskUsers.SelectedItem.ToString() + "'", "UserID")[0]).ToString();
                    sqlAct.InsertToTables("INSERT INTO dbo.TaskRemarks ( TaskID ,Remarks ,UserID , CreateDate ,Stat) VALUES  ( '" + projectTaskId + "','" + txtTaskName.Text + "','" + getTaskUsr + "', GETDATE(),'0')");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
