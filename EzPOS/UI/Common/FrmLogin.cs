using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EzPOS.UI.Common
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void LoadBranches()
        {
            txtBranch.Properties.DataSource = Services.Login.GetAllBranchesByUser(txtUsername.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Services.Login.VerifyLogin(txtUsername.Text, txtPassword.Text, txtBranch.EditValue.ToString()))
            {
                MessageBox.Show("Login Complete");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
