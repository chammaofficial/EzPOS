using System;
using System.Windows.Forms;
using EzPOS.UI;
using EzPOS.UI.Master_Files;

namespace EzPOS.UI.Common
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
            TimerDateTime.Interval = 500;
            TimerDateTime.Tick += TimerDateTime_Tick;
            TimerDateTime.Start();
            lblLoggedUser.Caption = $"User: {Session.LoginUser.Username}   |    Branch:  {Session.LoginBranch.Name} ({Session.LoginBranch.Code})";
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Caption = $"|   Date: {DateTime.Now.ToString("yyyy-MMM-dd")}    |   Time: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void barBtnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEmployee EmployeeForm = new FrmEmployee();
            EmployeeForm.MdiParent = documentManager1.MdiParent;
            EmployeeForm.Show();
        }

        private void Dashboard_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barBtnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSupplier SupplierForm = new FrmSupplier();
            SupplierForm.MdiParent = documentManager1.MdiParent;
            SupplierForm.Show();
        }

        private void barBtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomer CustomerForm = new FrmCustomer();
            CustomerForm.MdiParent = documentManager1.MdiParent;
            CustomerForm.Show();
        }
    }
}
