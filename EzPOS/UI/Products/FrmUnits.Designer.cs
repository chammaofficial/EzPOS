namespace EzPOS.UI.Products
{
    partial class FrmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnits));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GCUnits = new DevExpress.XtraGrid.GridControl();
            this.GVUnits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSymbol = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clmnSymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(735, 709);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AutoSize = true;
            this.groupControl2.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.list_view_32px;
            this.groupControl2.Controls.Add(this.GCUnits);
            this.groupControl2.Location = new System.Drawing.Point(11, 330);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(711, 359);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Units List";
            // 
            // GCUnits
            // 
            this.GCUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCUnits.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCUnits.Location = new System.Drawing.Point(2, 41);
            this.GCUnits.MainView = this.GVUnits;
            this.GCUnits.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCUnits.Name = "GCUnits";
            this.GCUnits.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkEdit,
            this.lnkDelete});
            this.GCUnits.Size = new System.Drawing.Size(707, 316);
            this.GCUnits.TabIndex = 0;
            this.GCUnits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVUnits});
            // 
            // GVUnits
            // 
            this.GVUnits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnId,
            this.clmnName,
            this.clmnSymbol,
            this.clmnEdit,
            this.clmnDelete});
            this.GVUnits.DetailHeight = 546;
            this.GVUnits.GridControl = this.GCUnits;
            this.GVUnits.Name = "GVUnits";
            // 
            // clmnId
            // 
            this.clmnId.Caption = "Id";
            this.clmnId.FieldName = "Id";
            this.clmnId.MinWidth = 27;
            this.clmnId.Name = "clmnId";
            this.clmnId.OptionsColumn.AllowEdit = false;
            this.clmnId.OptionsColumn.ReadOnly = true;
            this.clmnId.Visible = true;
            this.clmnId.VisibleIndex = 0;
            this.clmnId.Width = 116;
            // 
            // clmnName
            // 
            this.clmnName.Caption = "Name";
            this.clmnName.FieldName = "Name";
            this.clmnName.MinWidth = 27;
            this.clmnName.Name = "clmnName";
            this.clmnName.OptionsColumn.AllowEdit = false;
            this.clmnName.OptionsColumn.ReadOnly = true;
            this.clmnName.Visible = true;
            this.clmnName.VisibleIndex = 1;
            this.clmnName.Width = 173;
            // 
            // clmnEdit
            // 
            this.clmnEdit.Caption = "Edit";
            this.clmnEdit.ColumnEdit = this.lnkEdit;
            this.clmnEdit.MinWidth = 25;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Visible = true;
            this.clmnEdit.VisibleIndex = 3;
            this.clmnEdit.Width = 105;
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
            this.clmnDelete.VisibleIndex = 4;
            this.clmnDelete.Width = 113;
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
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.txtSymbol);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(11, 25);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Unit Details";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(95, 160);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(238, 23);
            this.txtSymbol.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Symbol :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(30, 197);
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
            this.BtnClear.Location = new System.Drawing.Point(254, 197);
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
            this.BtnSave.Location = new System.Drawing.Point(142, 197);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.EditValue = "[Auto Generated]";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(95, 82);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 23);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // clmnSymbol
            // 
            this.clmnSymbol.Caption = "Symbol";
            this.clmnSymbol.FieldName = "Symbol";
            this.clmnSymbol.MinWidth = 25;
            this.clmnSymbol.Name = "clmnSymbol";
            this.clmnSymbol.Visible = true;
            this.clmnSymbol.VisibleIndex = 2;
            this.clmnSymbol.Width = 181;
            // 
            // FrmUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(735, 709);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::EzPOS.Properties.Resources.trademark_32px;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmUnits.IconOptions.LargeImage")));
            this.Name = "FrmUnits";
            this.Text = "Units";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCUnits;
        private DevExpress.XtraGrid.Views.Grid.GridView GVUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn clmnId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDelete;
        private DevExpress.XtraEditors.TextEdit txtSymbol;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn clmnSymbol;
    }
}