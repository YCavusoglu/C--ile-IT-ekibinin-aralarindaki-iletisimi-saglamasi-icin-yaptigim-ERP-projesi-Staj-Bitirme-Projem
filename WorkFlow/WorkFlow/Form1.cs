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
    public partial class Form1 : Form
    {
        public string sessionUser;

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnectionCL sqlQr = new SqlConnectionCL();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            frmLogin frmLg = new frmLogin();
            dgrMyView.DataSource = sqlQr.BindGrid("SELECT * FROM dbo.Vw_WorkFlow AS vwf WHERE vwf.UserName='" + sessionUser + "'").Tables[0];
            for (int i = 0; i < sqlQr.GetQuery("SELECT * FROM dbo.Users AS u", "UserName").Count; i++)
            {
                cmbReportUsr.Items.Add(sqlQr.GetQuery("SELECT * FROM dbo.Users AS u", "UserName")[i]);
            }
        }
        Button AddProject = new Button();
        private void dgrMyView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip RightMenu = new System.Windows.Forms.ContextMenuStrip();
                RightMenu.Items.Add("Add Project").Name = "AddProject";
                RightMenu.Items.Add("Project Actions").Name = "ProjectActions";
                RightMenu.Show(dgrMyView, new Point(e.X, e.Y));
                RightMenu.ItemClicked += RightMenu_ItemClicked;
            }
        }

        void RightMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "AddProject":
                    frmAddProject frmPrj = new frmAddProject();
                    frmPrj.Show();
                    break;
                case "ProjectActions":
                    frmProjectActions frmAct = new frmProjectActions();
                    frmAct.Show();
                    break;
            }
        }
        private void cmbReportUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgrReport.DataSource = sqlQr.BindGrid("SELECT * FROM dbo.Vw_WorkFlow AS vwf WHERE vwf.UserName='" + cmbReportUsr.SelectedItem.ToString() + "'").Tables[0];
        }
    }
}