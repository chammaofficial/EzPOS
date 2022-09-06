using System;
using System.Windows.Forms;
using EzPOS.UI;
using EzPOS.UI.Master_Files;
using EzPOS.UI.Purchase;
using EzPOS.UI.Settings;

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

        private void barBtnBrands_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBrands BrandForm = new FrmBrands();
            BrandForm.MdiParent = documentManager1.MdiParent;
            BrandForm.Show();
        }

        private void barBtnCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCategories CategoryForm = new FrmCategories();
            CategoryForm.MdiParent = documentManager1.MdiParent;
            CategoryForm.Show();
        }

        private void barBtnProductMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProducts ProductForm = new FrmProducts();
            ProductForm.MdiParent = documentManager1.MdiParent;
            ProductForm.Show();
        }

        private void barBtnBarcodeConfiguration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Helpers.Alerts.Info("This is a Upcoming Feature. Not ready yet.");
            //FrmBarcodeConfiguration form = new FrmBarcodeConfiguration();
            //form.MdiParent = documentManager1.MdiParent;
            //form.Show();
        }

        private void barBtnPurchaseOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPurchaseOrder form = new FrmPurchaseOrder();
            form.MdiParent = documentManager1.MdiParent;
            form.Show();
        }

        private void barBtnBusinessSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBusinessSettings form = new FrmBusinessSettings();
            form.MdiParent = documentManager1.MdiParent;
            form.Show();
        }

        private void barBtnTaxSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaxSettings form = new FrmTaxSettings();
            form.MdiParent = documentManager1.MdiParent;
            form.Show();
        }

        private void barBtnBranches_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBranches form = new FrmBranches();
            form.MdiParent = documentManager1.MdiParent;
            form.Show();
        }
    }
}
