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
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Purchase
{
    public partial class FrmPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        private PurchaseOrder tempPurchaseOrder;
        public FrmPurchaseOrder()
        {
            InitializeComponent();
            tempPurchaseOrder = new PurchaseOrder();
        }

        private void FrmPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtSupplier.Properties.DataSource = PurchaseOrderService.GetSuppliers();
            GCPOHeader.DataSource = PurchaseOrderService.GetAllActivePurchaseOrders();
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
                    PurchaseOrderService.SavePurchaseOrderHeader(tempPurchaseOrder);
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
            tempPurchaseOrder = PurchaseOrderService.GetPurchaseOrderById(int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString()));
            tempPurchaseOrder.IsActive = false;
            tempPurchaseOrder.Status = "Canceled";

            if (tempPurchaseOrder.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to remove this customer ?. This operation cannot be reversed!.") == DialogResult.Yes)
                {
                    PurchaseOrderService.SavePurchaseOrderHeader(tempPurchaseOrder);
                    Clear();
                }
            }
            LoadData();
            tempPurchaseOrder = new PurchaseOrder();
        }

        private void lnkEdit_Click(object sender, EventArgs e)
        {
            tempPurchaseOrder = PurchaseOrderService.GetPurchaseOrderById(int.Parse(GVPOHeader.GetRowCellValue(GVPOHeader.FocusedRowHandle, clmnPOHeadId).ToString()));
            txtPODate.EditValue = tempPurchaseOrder.PoDate;
            txtSupplier.EditValue = tempPurchaseOrder.SupplierId;
            txtDeliveryDate.EditValue = tempPurchaseOrder.DeliveryDate;
            txtRemark.EditValue = tempPurchaseOrder.Remark;
        }
    }
}
