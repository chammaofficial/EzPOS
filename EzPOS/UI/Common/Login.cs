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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void LoadBranches()
        {
             txtBranch.Properties.DataSource = Services.LoginService.GetAllBranches();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBranch.EditValue == null)
                Helpers.Alerts.Info("Please Select a Branch to login.");
            else
            {
                if (Services.LoginService.VerifyLogin(txtUsername.Text, txtPassword.Text, txtBranch.EditValue.ToString()))
                {
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    Helpers.Alerts.Error("Login Failed.");
                }
            }        
        }
    }
}
