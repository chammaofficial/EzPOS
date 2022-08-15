using System;
using EzPOS.UI;

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
            Employee.FrmEmployee EmployeeForm = new Employee.FrmEmployee();
            EmployeeForm.MdiParent = documentManager1.MdiParent;
            EmployeeForm.Show();
        }
    }
}
