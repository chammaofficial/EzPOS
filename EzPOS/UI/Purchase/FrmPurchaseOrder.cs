using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraReports.UI;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Reports.DataSets.Purchase;
using EzPOS.Reports.DataSets.Purchase.DataSetPurchaseOrderTableAdapters;
using EzPOS.Reports.ReportFiles.Purchase;
using EzPOS.Services;

namespace EzPOS.UI.Purchase
{
    public partial class FrmPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        private PurchaseOrder tempPurchaseOrder;
        private PurchaseOrderService purchaseOrderService;
        public FrmPurchaseOrder()
        {
            InitializeComponent();
            tempPurchaseOrder = new PurchaseOrder();
            var context = new POSContext();
            purchaseOrderService = new PurchaseOrderService(context);
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var POHeads = purchaseOrderService.GetAllActivePurchaseOrders();
            var Suppliers = purchaseOrderService.GetSuppliers();

            txtSupplier.Properties.DataSource = Suppliers;
            GCPOHeader.DataSource = POHeads;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tempPurchaseOrder = new PurchaseOrder();
            txtRemark.Clear();
            txtDeliveryDate.EditValue = null;
            txtPODate.EditValue = null;
            txtSupplier.EditValue = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tempPurchaseOrder.PoDate = (DateTime) txtPODate.EditValue;
            tempPurchaseOrder.SupplierId = (int) txtSupplier.EditValue;
            tempPurchaseOrder.DeliveryDate = (DateTime) txtDeliveryDate.EditValue;
            tempPurchaseOrder.Remark = txtRemark.Text;
            tempPurchaseOrder.BranchId = Session.LoginBranch.Id;
            tempPurchaseOrder.Status = "OPEN";
            tempPurchaseOrder.IsActive = true;

           
            if (tempPurchaseOrder.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Purchase Order ?") == DialogResult.Yes)
                {
                    purchaseOrderService.SavePurchaseOrderHeader(tempPurchaseOrder);
                    Clear();
                }
            }
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lnkDelete_Click(object sender, EventArgs e)
        {
            tempPurchaseOrder = purchaseOrderService.GetPurchaseOrderById(int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString()));
            tempPurchaseOrder.IsActive = false;
            tempPurchaseOrder.Status = "Canceled";

            if (tempPurchaseOrder.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this customer ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    purchaseOrderService.SavePurchaseOrderHeader(tempPurchaseOrder);
                    Clear();
                }
            }
            LoadData();
            tempPurchaseOrder = new PurchaseOrder();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            tempPurchaseOrder = purchaseOrderService.GetPurchaseOrderById(int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString()));
            txtPODate.EditValue = tempPurchaseOrder.PoDate;
            txtSupplier.EditValue = tempPurchaseOrder.SupplierId;
            txtDeliveryDate.EditValue = tempPurchaseOrder.DeliveryDate;
            txtRemark.EditValue = tempPurchaseOrder.Remark;
        }

        private void lnkPODetails_Click(object sender, EventArgs e)
        {
            int POID = int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString());
            FrmPurchaseOrderDetails form = new FrmPurchaseOrderDetails(purchaseOrderService, POID);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void lnkPrint_Click(object sender, EventArgs e)
        {
            int id = int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString());
            Reports.ReportFiles.Purchase.PurchaseOrderReport report = new PurchaseOrderReport();
            Reports.DataSets.Purchase.DataSetPurchaseOrder.PurchaseOrderReportDataTable table = new DataSetPurchaseOrder.PurchaseOrderReportDataTable();
            Reports.DataSets.Purchase.DataSetPurchaseOrderTableAdapters.PurchaseOrderReportTableAdapter Adapter = new PurchaseOrderReportTableAdapter();
            Adapter.Fill(table, id);
            report.DataSource = table;
            report.ShowPreview();

        }
    }
}
