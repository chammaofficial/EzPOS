namespace EzPOS.UI.Purchase
{
    partial class FrmPurchaseOrder
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
            this.GCPOHeader = new DevExpress.XtraGrid.GridControl();
            this.GVPOHeader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnPOHeadId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadPODate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeaDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadUpdateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPOHeadPODetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkPODetails = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnPrintPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkPrint = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtPOId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.txtPODate = new DevExpress.XtraEditors.DateEdit();
            this.txtSupplier = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnSupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnSupName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCPOHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPOHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPODetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.list_view_32px;
            this.groupControl2.Controls.Add(this.GCPOHeader);
            this.groupControl2.Location = new System.Drawing.Point(16, 260);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1061, 392);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Pruchase Orders List";
            // 
            // GCPOHeader
            // 
            this.GCPOHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCPOHeader.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCPOHeader.Location = new System.Drawing.Point(2, 41);
            this.GCPOHeader.MainView = this.GVPOHeader;
            this.GCPOHeader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCPOHeader.Name = "GCPOHeader";
            this.GCPOHeader.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkEdit,
            this.lnkDelete,
            this.lnkPODetails,
            this.lnkPrint});
            this.GCPOHeader.Size = new System.Drawing.Size(1057, 349);
            this.GCPOHeader.TabIndex = 0;
            this.GCPOHeader.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVPOHeader});
            // 
            // GVPOHeader
            // 
            this.GVPOHeader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnPOHeadId,
            this.clmnPOHeadPODate,
            this.clmnPOHeadSupplier,
            this.clmnPOHeaDeliveryDate,
            this.clmnPOHeadRemark,
            this.clmnPOHeadStatus,
            this.clmnPOHeadActive,
            this.clmnPOHeadCreateBy,
            this.clmnPOHeadCreateDate,
            this.clmnPOHeadUpdateBy,
            this.clmnPOHeadUpdateDate,
            this.clmnPOHeadPODetails,
            this.clmnPrintPO,
            this.clmnEdit,
            this.clmnDelete});
            this.GVPOHeader.DetailHeight = 546;
            this.GVPOHeader.GridControl = this.GCPOHeader;
            this.GVPOHeader.Name = "GVPOHeader";
            this.GVPOHeader.OptionsBehavior.ReadOnly = true;
            // 
            // clmnPOHeadId
            // 
            this.clmnPOHeadId.Caption = "Id";
            this.clmnPOHeadId.FieldName = "Id";
            this.clmnPOHeadId.MinWidth = 27;
            this.clmnPOHeadId.Name = "clmnPOHeadId";
            this.clmnPOHeadId.OptionsColumn.ReadOnly = true;
            this.clmnPOHeadId.Visible = true;
            this.clmnPOHeadId.VisibleIndex = 0;
            this.clmnPOHeadId.Width = 102;
            // 
            // clmnPOHeadPODate
            // 
            this.clmnPOHeadPODate.Caption = "PO Date";
            this.clmnPOHeadPODate.FieldName = "PoDate";
            this.clmnPOHeadPODate.MinWidth = 27;
            this.clmnPOHeadPODate.Name = "clmnPOHeadPODate";
            this.clmnPOHeadPODate.OptionsColumn.AllowEdit = false;
            this.clmnPOHeadPODate.OptionsColumn.ReadOnly = true;
            this.clmnPOHeadPODate.Visible = true;
            this.clmnPOHeadPODate.VisibleIndex = 1;
            this.clmnPOHeadPODate.Width = 102;
            // 
            // clmnPOHeadSupplier
            // 
            this.clmnPOHeadSupplier.Caption = "Supplier";
            this.clmnPOHeadSupplier.FieldName = "Supplier.Name";
            this.clmnPOHeadSupplier.MinWidth = 27;
            this.clmnPOHeadSupplier.Name = "clmnPOHeadSupplier";
            this.clmnPOHeadSupplier.OptionsColumn.AllowEdit = false;
            this.clmnPOHeadSupplier.OptionsColumn.ReadOnly = true;
            this.clmnPOHeadSupplier.Visible = true;
            this.clmnPOHeadSupplier.VisibleIndex = 2;
            this.clmnPOHeadSupplier.Width = 102;
            // 
            // clmnPOHeaDeliveryDate
            // 
            this.clmnPOHeaDeliveryDate.Caption = "Delivery Date";
            this.clmnPOHeaDeliveryDate.FieldName = "DeliveryDate";
            this.clmnPOHeaDeliveryDate.MinWidth = 27;
            this.clmnPOHeaDeliveryDate.Name = "clmnPOHeaDeliveryDate";
            this.clmnPOHeaDeliveryDate.OptionsColumn.AllowEdit = false;
            this.clmnPOHeaDeliveryDate.OptionsColumn.ReadOnly = true;
            this.clmnPOHeaDeliveryDate.Visible = true;
            this.clmnPOHeaDeliveryDate.VisibleIndex = 3;
            this.clmnPOHeaDeliveryDate.Width = 102;
            // 
            // clmnPOHeadRemark
            // 
            this.clmnPOHeadRemark.Caption = "Remark";
            this.clmnPOHeadRemark.FieldName = "Remark";
            this.clmnPOHeadRemark.MinWidth = 27;
            this.clmnPOHeadRemark.Name = "clmnPOHeadRemark";
            this.clmnPOHeadRemark.OptionsColumn.AllowEdit = false;
            this.clmnPOHeadRemark.OptionsColumn.ReadOnly = true;
            this.clmnPOHeadRemark.Visible = true;
            this.clmnPOHeadRemark.VisibleIndex = 4;
            this.clmnPOHeadRemark.Width = 102;
            // 
            // clmnPOHeadStatus
            // 
            this.clmnPOHeadStatus.Caption = "Status";
            this.clmnPOHeadStatus.FieldName = "Status";
            this.clmnPOHeadStatus.MinWidth = 25;
            this.clmnPOHeadStatus.Name = "clmnPOHeadStatus";
            this.clmnPOHeadStatus.Visible = true;
            this.clmnPOHeadStatus.VisibleIndex = 5;
            this.clmnPOHeadStatus.Width = 94;
            // 
            // clmnPOHeadActive
            // 
            this.clmnPOHeadActive.Caption = "Active";
            this.clmnPOHeadActive.FieldName = "IsActive";
            this.clmnPOHeadActive.MinWidth = 25;
            this.clmnPOHeadActive.Name = "clmnPOHeadActive";
            this.clmnPOHeadActive.Width = 94;
            // 
            // clmnPOHeadCreateBy
            // 
            this.clmnPOHeadCreateBy.Caption = "Create By";
            this.clmnPOHeadCreateBy.FieldName = "CreateBy";
            this.clmnPOHeadCreateBy.MinWidth = 25;
            this.clmnPOHeadCreateBy.Name = "clmnPOHeadCreateBy";
            this.clmnPOHeadCreateBy.Visible = true;
            this.clmnPOHeadCreateBy.VisibleIndex = 6;
            this.clmnPOHeadCreateBy.Width = 94;
            // 
            // clmnPOHeadCreateDate
            // 
            this.clmnPOHeadCreateDate.Caption = "Create Date";
            this.clmnPOHeadCreateDate.FieldName = "CreateDate";
            this.clmnPOHeadCreateDate.MinWidth = 25;
            this.clmnPOHeadCreateDate.Name = "clmnPOHeadCreateDate";
            this.clmnPOHeadCreateDate.Visible = true;
            this.clmnPOHeadCreateDate.VisibleIndex = 7;
            this.clmnPOHeadCreateDate.Width = 94;
            // 
            // clmnPOHeadUpdateBy
            // 
            this.clmnPOHeadUpdateBy.Caption = "Update By";
            this.clmnPOHeadUpdateBy.FieldName = "UpdateBy";
            this.clmnPOHeadUpdateBy.MinWidth = 25;
            this.clmnPOHeadUpdateBy.Name = "clmnPOHeadUpdateBy";
            this.clmnPOHeadUpdateBy.Width = 94;
            // 
            // clmnPOHeadUpdateDate
            // 
            this.clmnPOHeadUpdateDate.Caption = "Update Date";
            this.clmnPOHeadUpdateDate.FieldName = "UpdateDate";
            this.clmnPOHeadUpdateDate.MinWidth = 25;
            this.clmnPOHeadUpdateDate.Name = "clmnPOHeadUpdateDate";
            this.clmnPOHeadUpdateDate.Width = 94;
            // 
            // clmnPOHeadPODetails
            // 
            this.clmnPOHeadPODetails.Caption = "PO Details";
            this.clmnPOHeadPODetails.ColumnEdit = this.lnkPODetails;
            this.clmnPOHeadPODetails.FieldName = "PO Details";
            this.clmnPOHeadPODetails.MinWidth = 25;
            this.clmnPOHeadPODetails.Name = "clmnPOHeadPODetails";
            this.clmnPOHeadPODetails.Visible = true;
            this.clmnPOHeadPODetails.VisibleIndex = 8;
            this.clmnPOHeadPODetails.Width = 94;
            // 
            // lnkPODetails
            // 
            this.lnkPODetails.AutoHeight = false;
            this.lnkPODetails.Caption = "PO Details";
            this.lnkPODetails.Name = "lnkPODetails";
            this.lnkPODetails.NullText = "PO Details";
            this.lnkPODetails.Click += new System.EventHandler(this.lnkPODetails_Click);
            // 
            // clmnPrintPO
            // 
            this.clmnPrintPO.Caption = "Print";
            this.clmnPrintPO.ColumnEdit = this.lnkPrint;
            this.clmnPrintPO.FieldName = "Print";
            this.clmnPrintPO.MinWidth = 25;
            this.clmnPrintPO.Name = "clmnPrintPO";
            this.clmnPrintPO.Visible = true;
            this.clmnPrintPO.VisibleIndex = 9;
            this.clmnPrintPO.Width = 94;
            // 
            // lnkPrint
            // 
            this.lnkPrint.AutoHeight = false;
            this.lnkPrint.Caption = "Print";
            this.lnkPrint.Name = "lnkPrint";
            this.lnkPrint.NullText = "Print";
            this.lnkPrint.Click += new System.EventHandler(this.lnkPrint_Click);
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
            this.lnkEdit.Click += new System.EventHandler(this.lnkEdit_Click);
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
            this.lnkDelete.Click += new System.EventHandler(this.lnkDelete_Click);
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
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtRemark);
            this.groupControl1.Controls.Add(this.txtPOId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtDeliveryDate);
            this.groupControl1.Controls.Add(this.txtPODate);
            this.groupControl1.Controls.Add(this.txtSupplier);
            this.groupControl1.Location = new System.Drawing.Point(16, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1061, 235);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Purchase Order Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(440, 156);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = global::EzPOS.Properties.Resources.eraser_tool_32px;
            this.BtnClear.Location = new System.Drawing.Point(664, 156);
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
            this.BtnSave.Location = new System.Drawing.Point(552, 156);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delivery Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 120);
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
            this.label3.Location = new System.Drawing.Point(20, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Supplier :";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(493, 119);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(273, 23);
            this.txtRemark.TabIndex = 3;
            // 
            // txtPOId
            // 
            this.txtPOId.EditValue = "[Auto Generated]";
            this.txtPOId.Enabled = false;
            this.txtPOId.Location = new System.Drawing.Point(96, 82);
            this.txtPOId.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPOId.Name = "txtPOId";
            this.txtPOId.Size = new System.Drawing.Size(238, 23);
            this.txtPOId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PO Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PO Id :";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.EditValue = null;
            this.txtDeliveryDate.Location = new System.Drawing.Point(493, 82);
            this.txtDeliveryDate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDeliveryDate.Properties.DisplayFormat.FormatString = "";
            this.txtDeliveryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDeliveryDate.Properties.EditFormat.FormatString = "";
            this.txtDeliveryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDeliveryDate.Properties.MaskSettings.Set("mask", " yyyy - MMM - dd");
            this.txtDeliveryDate.Size = new System.Drawing.Size(273, 23);
            this.txtDeliveryDate.TabIndex = 2;
            // 
            // txtPODate
            // 
            this.txtPODate.EditValue = null;
            this.txtPODate.Location = new System.Drawing.Point(95, 119);
            this.txtPODate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPODate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPODate.Properties.DisplayFormat.FormatString = "";
            this.txtPODate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPODate.Properties.EditFormat.FormatString = "";
            this.txtPODate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPODate.Properties.MaskSettings.Set("mask", " yyyy - MMM - dd");
            this.txtPODate.Size = new System.Drawing.Size(238, 23);
            this.txtPODate.TabIndex = 0;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(96, 158);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSupplier.Properties.DisplayMember = "Name";
            this.txtSupplier.Properties.NullText = "";
            this.txtSupplier.Properties.PopupView = this.gridLookUpEdit1View;
            this.txtSupplier.Properties.ValueMember = "Id";
            this.txtSupplier.Size = new System.Drawing.Size(238, 23);
            this.txtSupplier.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnSupId,
            this.clmnSupName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clmnSupId
            // 
            this.clmnSupId.Caption = "Id";
            this.clmnSupId.FieldName = "Id";
            this.clmnSupId.Name = "clmnSupId";
            this.clmnSupId.Visible = true;
            this.clmnSupId.VisibleIndex = 0;
            // 
            // clmnSupName
            // 
            this.clmnSupName.Caption = "Name";
            this.clmnSupName.FieldName = "Name";
            this.clmnSupName.Name = "clmnSupName";
            this.clmnSupName.Visible = true;
            this.clmnSupName.VisibleIndex = 1;
            // 
            // FrmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 659);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPurchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.FrmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCPOHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPOHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPODetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCPOHeader;
        private DevExpress.XtraGrid.Views.Grid.GridView GVPOHeader;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadPODate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeaDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadRemark;
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
        private DevExpress.XtraEditors.TextEdit txtPOId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtPODate;
        private DevExpress.XtraEditors.GridLookUpEdit txtSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadActive;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadUpdateBy;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPOHeadPODetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkPODetails;
        private DevExpress.XtraGrid.Columns.GridColumn clmnSupId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnSupName;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit txtDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPrintPO;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkPrint;
    }
}