namespace EzPOS.UI.Purchase
{
    partial class FrmPurchaseOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GCPODetails = new DevExpress.XtraGrid.GridControl();
            this.GVPODetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnPODetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetReceiveQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetBalanceQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnLineItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetUpdateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPODetUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.lnkPODetails = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOrderQty = new DevExpress.XtraEditors.TextEdit();
            this.clmnProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCPODetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPODetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPODetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.list_view_32px;
            this.groupControl2.Controls.Add(this.GCPODetails);
            this.groupControl2.Location = new System.Drawing.Point(16, 260);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1047, 392);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Pruchase Order Details List";
            // 
            // GCPODetails
            // 
            this.GCPODetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCPODetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCPODetails.Location = new System.Drawing.Point(2, 41);
            this.GCPODetails.MainView = this.GVPODetails;
            this.GCPODetails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCPODetails.Name = "GCPODetails";
            this.GCPODetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkEdit,
            this.lnkDelete,
            this.lnkPODetails});
            this.GCPODetails.Size = new System.Drawing.Size(1043, 349);
            this.GCPODetails.TabIndex = 0;
            this.GCPODetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVPODetails});
            // 
            // GVPODetails
            // 
            this.GVPODetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnPODetId,
            this.clmnPODetProduct,
            this.clmnPODetOrderQty,
            this.clmnPODetReceiveQty,
            this.clmnPODetBalanceQty,
            this.clmnPODetRemark,
            this.clmnLineItemNo,
            this.clmnPODetStatus,
            this.clmnPODetActive,
            this.clmnPODetCreateBy,
            this.clmnPODetCreateDate,
            this.clmnPODetUpdateBy,
            this.clmnPODetUpdateDate,
            this.clmnEdit,
            this.clmnDelete});
            this.GVPODetails.DetailHeight = 546;
            this.GVPODetails.GridControl = this.GCPODetails;
            this.GVPODetails.Name = "GVPODetails";
            this.GVPODetails.OptionsBehavior.ReadOnly = true;
            // 
            // clmnPODetId
            // 
            this.clmnPODetId.Caption = "Id";
            this.clmnPODetId.FieldName = "Id";
            this.clmnPODetId.MinWidth = 27;
            this.clmnPODetId.Name = "clmnPODetId";
            this.clmnPODetId.OptionsColumn.ReadOnly = true;
            this.clmnPODetId.Visible = true;
            this.clmnPODetId.VisibleIndex = 0;
            this.clmnPODetId.Width = 102;
            // 
            // clmnPODetProduct
            // 
            this.clmnPODetProduct.Caption = "Product";
            this.clmnPODetProduct.FieldName = "Product.Name";
            this.clmnPODetProduct.MinWidth = 27;
            this.clmnPODetProduct.Name = "clmnPODetProduct";
            this.clmnPODetProduct.OptionsColumn.AllowEdit = false;
            this.clmnPODetProduct.OptionsColumn.ReadOnly = true;
            this.clmnPODetProduct.Visible = true;
            this.clmnPODetProduct.VisibleIndex = 1;
            this.clmnPODetProduct.Width = 102;
            // 
            // clmnPODetOrderQty
            // 
            this.clmnPODetOrderQty.Caption = "Order Qty";
            this.clmnPODetOrderQty.FieldName = "OrderQty";
            this.clmnPODetOrderQty.MinWidth = 27;
            this.clmnPODetOrderQty.Name = "clmnPODetOrderQty";
            this.clmnPODetOrderQty.OptionsColumn.AllowEdit = false;
            this.clmnPODetOrderQty.OptionsColumn.ReadOnly = true;
            this.clmnPODetOrderQty.Visible = true;
            this.clmnPODetOrderQty.VisibleIndex = 2;
            this.clmnPODetOrderQty.Width = 102;
            // 
            // clmnPODetReceiveQty
            // 
            this.clmnPODetReceiveQty.Caption = "Received Qty";
            this.clmnPODetReceiveQty.FieldName = "ReceivedQty";
            this.clmnPODetReceiveQty.MinWidth = 27;
            this.clmnPODetReceiveQty.Name = "clmnPODetReceiveQty";
            this.clmnPODetReceiveQty.OptionsColumn.AllowEdit = false;
            this.clmnPODetReceiveQty.OptionsColumn.ReadOnly = true;
            this.clmnPODetReceiveQty.Visible = true;
            this.clmnPODetReceiveQty.VisibleIndex = 4;
            this.clmnPODetReceiveQty.Width = 102;
            // 
            // clmnPODetBalanceQty
            // 
            this.clmnPODetBalanceQty.Caption = "Balance Qty";
            this.clmnPODetBalanceQty.FieldName = "BalanceQty";
            this.clmnPODetBalanceQty.MinWidth = 25;
            this.clmnPODetBalanceQty.Name = "clmnPODetBalanceQty";
            this.clmnPODetBalanceQty.Visible = true;
            this.clmnPODetBalanceQty.VisibleIndex = 3;
            this.clmnPODetBalanceQty.Width = 94;
            // 
            // clmnPODetRemark
            // 
            this.clmnPODetRemark.Caption = "Remark";
            this.clmnPODetRemark.FieldName = "Remark";
            this.clmnPODetRemark.MinWidth = 27;
            this.clmnPODetRemark.Name = "clmnPODetRemark";
            this.clmnPODetRemark.OptionsColumn.AllowEdit = false;
            this.clmnPODetRemark.OptionsColumn.ReadOnly = true;
            this.clmnPODetRemark.Visible = true;
            this.clmnPODetRemark.VisibleIndex = 6;
            this.clmnPODetRemark.Width = 102;
            // 
            // clmnLineItemNo
            // 
            this.clmnLineItemNo.Caption = "Line No";
            this.clmnLineItemNo.FieldName = "LineItemNo";
            this.clmnLineItemNo.MinWidth = 25;
            this.clmnLineItemNo.Name = "clmnLineItemNo";
            this.clmnLineItemNo.Visible = true;
            this.clmnLineItemNo.VisibleIndex = 5;
            this.clmnLineItemNo.Width = 94;
            // 
            // clmnPODetStatus
            // 
            this.clmnPODetStatus.Caption = "Status";
            this.clmnPODetStatus.FieldName = "Status";
            this.clmnPODetStatus.MinWidth = 25;
            this.clmnPODetStatus.Name = "clmnPODetStatus";
            this.clmnPODetStatus.Visible = true;
            this.clmnPODetStatus.VisibleIndex = 7;
            this.clmnPODetStatus.Width = 94;
            // 
            // clmnPODetActive
            // 
            this.clmnPODetActive.Caption = "Active";
            this.clmnPODetActive.FieldName = "IsActive";
            this.clmnPODetActive.MinWidth = 25;
            this.clmnPODetActive.Name = "clmnPODetActive";
            this.clmnPODetActive.Width = 94;
            // 
            // clmnPODetCreateBy
            // 
            this.clmnPODetCreateBy.Caption = "Create By";
            this.clmnPODetCreateBy.FieldName = "CreateBy";
            this.clmnPODetCreateBy.MinWidth = 25;
            this.clmnPODetCreateBy.Name = "clmnPODetCreateBy";
            this.clmnPODetCreateBy.Visible = true;
            this.clmnPODetCreateBy.VisibleIndex = 8;
            this.clmnPODetCreateBy.Width = 94;
            // 
            // clmnPODetCreateDate
            // 
            this.clmnPODetCreateDate.Caption = "Create Date";
            this.clmnPODetCreateDate.FieldName = "CreateDate";
            this.clmnPODetCreateDate.MinWidth = 25;
            this.clmnPODetCreateDate.Name = "clmnPODetCreateDate";
            this.clmnPODetCreateDate.Visible = true;
            this.clmnPODetCreateDate.VisibleIndex = 9;
            this.clmnPODetCreateDate.Width = 94;
            // 
            // clmnPODetUpdateBy
            // 
            this.clmnPODetUpdateBy.Caption = "Update By";
            this.clmnPODetUpdateBy.FieldName = "UpdateBy";
            this.clmnPODetUpdateBy.MinWidth = 25;
            this.clmnPODetUpdateBy.Name = "clmnPODetUpdateBy";
            this.clmnPODetUpdateBy.Width = 94;
            // 
            // clmnPODetUpdateDate
            // 
            this.clmnPODetUpdateDate.Caption = "Update Date";
            this.clmnPODetUpdateDate.FieldName = "UpdateDate";
            this.clmnPODetUpdateDate.MinWidth = 25;
            this.clmnPODetUpdateDate.Name = "clmnPODetUpdateDate";
            this.clmnPODetUpdateDate.Width = 94;
            // 
            // clmnEdit
            // 
            this.clmnEdit.Caption = "Edit";
            this.clmnEdit.ColumnEdit = this.lnkEdit;
            this.clmnEdit.MinWidth = 25;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Visible = true;
            this.clmnEdit.VisibleIndex = 10;
            this.clmnEdit.Width = 94;
            // 
            // lnkEdit
            // 
            this.lnkEdit.AutoHeight = false;
            this.lnkEdit.Caption = "Edit";
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.NullText = "Edit";
            // 
            // clmnDelete
            // 
            this.clmnDelete.Caption = "Delete";
            this.clmnDelete.ColumnEdit = this.lnkDelete;
            this.clmnDelete.MinWidth = 25;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Visible = true;
            this.clmnDelete.VisibleIndex = 11;
            this.clmnDelete.Width = 94;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoHeight = false;
            this.lnkDelete.Caption = "Delete";
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.NullText = "Delete";
            // 
            // lnkPODetails
            // 
            this.lnkPODetails.AutoHeight = false;
            this.lnkPODetails.Caption = "PO Details";
            this.lnkPODetails.Name = "lnkPODetails";
            this.lnkPODetails.NullText = "PO Details";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.purchase_order_32px;
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtRemark);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtProduct);
            this.groupControl1.Controls.Add(this.txtOrderQty);
            this.groupControl1.Location = new System.Drawing.Point(16, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1047, 235);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Purchase Order Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(384, 175);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = global::EzPOS.Properties.Resources.eraser_tool_32px;
            this.BtnClear.Location = new System.Drawing.Point(608, 175);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(102, 34);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = global::EzPOS.Properties.Resources.save_32px;
            this.BtnSave.Location = new System.Drawing.Point(496, 175);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remark :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Qty:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(95, 181);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(238, 23);
            this.txtRemark.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.EditValue = "[Auto Generated]";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(95, 68);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 23);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(94, 105);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProduct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtProduct.Properties.DisplayMember = "Name";
            this.txtProduct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtProduct.Properties.NullText = "";
            this.txtProduct.Properties.PopupView = this.gridView1;
            this.txtProduct.Properties.ValueMember = "Id";
            this.txtProduct.Size = new System.Drawing.Size(238, 23);
            this.txtProduct.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnProductId,
            this.clmnProductName,
            this.clmnProductDescription});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(95, 144);
            this.txtOrderQty.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(238, 23);
            this.txtOrderQty.TabIndex = 1;
            // 
            // clmnProductId
            // 
            this.clmnProductId.Caption = "Id";
            this.clmnProductId.FieldName = "Id";
            this.clmnProductId.Name = "clmnProductId";
            this.clmnProductId.Visible = true;
            this.clmnProductId.VisibleIndex = 0;
            // 
            // clmnProductName
            // 
            this.clmnProductName.Caption = "Name";
            this.clmnProductName.FieldName = "Name";
            this.clmnProductName.Name = "clmnProductName";
            this.clmnProductName.Visible = true;
            this.clmnProductName.VisibleIndex = 1;
            // 
            // clmnProductDescription
            // 
            this.clmnProductDescription.Caption = "Description";
            this.clmnProductDescription.FieldName = "Description";
            this.clmnProductDescription.Name = "clmnProductDescription";
            this.clmnProductDescription.Visible = true;
            this.clmnProductDescription.VisibleIndex = 2;
            // 
            // FrmPurchaseOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 670);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPurchaseOrderDetails";
            this.Text = "Purchase Order Details";
            this.Load += new System.EventHandler(this.FrmPurchaseOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCPODetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPODetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPODetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderQty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCPODetails;
        private DevExpress.XtraGrid.Views.Grid.GridView GVPODetails;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetReceiveQty;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetRemark;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetActive;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetUpdateBy;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetUpdateDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkPODetails;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkDelete;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPODetBalanceQty;
        private DevExpress.XtraGrid.Columns.GridColumn clmnLineItemNo;
        private DevExpress.XtraEditors.GridLookUpEdit txtProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductDescription;
    }
}