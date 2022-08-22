using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzPOS.Helpers;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Purchase
{
    public partial class FrmPurchaseOrderDetails : DevExpress.XtraEditors.XtraForm
    {
        private PurchaseOrderService service;
        private PurchaseOrderDetail PODetail;
        private int POId;
        public FrmPurchaseOrderDetails(PurchaseOrderService service, int POId)
        {
            InitializeComponent();
            this.service = service;
            PODetail = new PurchaseOrderDetail();
            this.POId = POId;
        }

        private void FrmPurchaseOrderDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            PODetail = new PurchaseOrderDetail();
            txtOrderQty.Clear();
            txtRemark.Clear();
            txtProduct.Clear();
        }

        private void LoadData()
        {
            GCPODetails.DataSource = service.GetAllActivePurchaseOrdersDetailsByPurchaseOrderId(POId);
            txtProduct.Properties.DataSource = service.GetAllActiveProducts();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            PODetail.ProductId = (int) txtProduct.EditValue;
            PODetail.IsActive = true;
            PODetail.PurchaseOrderId = POId;
            PODetail.BalanceQty = decimal.Parse(txtOrderQty.Text);
            PODetail.OrderQty = decimal.Parse(txtOrderQty.Text);
            PODetail.ReceivedQty = 0;
            PODetail.Status = "ACTIVE";
            PODetail.Remark = txtRemark.Text;
            PODetail.LineItemNo = service.GetNextLineItemNoByPoID(POId);
            PODetail.Status = "OPEN";
            PODetail.IsActive = true;


            if (PODetail.Validate() == true)
            {
                if (Alerts.Confirm("Are sure want to save this Purchase Detail ?") == DialogResult.Yes)
                {
                    service.SavePurchaseOrderDetail(PODetail);
                    Clear();
                }
            }
            LoadData();
        }
    }
}
