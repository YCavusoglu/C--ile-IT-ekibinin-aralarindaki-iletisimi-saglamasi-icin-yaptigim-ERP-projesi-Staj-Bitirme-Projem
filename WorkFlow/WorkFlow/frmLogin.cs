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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnectionCL sqlCn = new SqlConnectionCL();
        string queryLogin, queryColumn;
        List<string> getUsers = new List<string>();
        Form1 frmProject = new Form1();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            queryLogin = "SELECT u.UserName FROM dbo.Users AS u";
            queryColumn = "UserName";
            getUsers = sqlCn.GetQuery(queryLogin, queryColumn);
            for (int i = 0; i < getUsers.Count; i++)
            {
                cmbUsers.Items.Add(getUsers[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            getUsers.Clear();
            queryLogin = "SELECT * FROM dbo.Users AS u WHERE u.UserName='" + cmbUsers.SelectedItem.ToString() + "' AND u.Password='" + txtPassword.Text + "'";
            queryColumn = "Password";
            getUsers = sqlCn.GetQuery(queryLogin, queryColumn);
            if (getUsers.Count == 1)
            {
                frmProject.sessionUser = cmbUsers.SelectedItem.ToString();
                this.Hide();
                frmProject.Show();
            }
            else
            {
                MessageBox.Show("Check your user name or password!");
            }
        }
    }
}
