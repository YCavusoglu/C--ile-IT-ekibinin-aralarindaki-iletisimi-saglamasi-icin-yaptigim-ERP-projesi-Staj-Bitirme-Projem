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
    public partial class frmAddProject : Form
    {
        public frmAddProject()
        {
            InitializeComponent();
        }
        SqlConnectionCL sqlIns = new SqlConnectionCL();
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            sqlIns.InsertToTables("INSERT INTO dbo.Projects ( ProjectName, Stat ) VALUES  ('" + txtProjectName.Text + "',0 )");
            this.Close();
        }
    }
}
