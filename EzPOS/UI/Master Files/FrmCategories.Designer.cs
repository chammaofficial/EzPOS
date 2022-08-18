namespace EzPOS.UI.Master_Files
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GCCategory = new DevExpress.XtraGrid.GridControl();
            this.GVCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnIsSubCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnSubCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParentCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnParentName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.GCCategory);
            this.groupControl2.Location = new System.Drawing.Point(11, 330);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(711, 359);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Employee List";
            // 
            // GCCategory
            // 
            this.GCCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCCategory.Location = new System.Drawing.Point(2, 49);
            this.GCCategory.MainView = this.GVCategory;
            this.GCCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCCategory.Name = "GCCategory";
            this.GCCategory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkEdit,
            this.lnkDelete});
            this.GCCategory.Size = new System.Drawing.Size(707, 308);
            this.GCCategory.TabIndex = 0;
            this.GCCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVCategory});
            // 
            // GVCategory
            // 
            this.GVCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnId,
            this.clmnName,
            this.clmnIsSubCategory,
            this.clmnSubCategoryName,
            this.clmnEdit,
            this.clmnDelete});
            this.GVCategory.DetailHeight = 546;
            this.GVCategory.GridControl = this.GCCategory;
            this.GVCategory.Name = "GVCategory";
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
            this.clmnId.Width = 102;
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
            this.clmnName.Width = 102;
            // 
            // clmnIsSubCategory
            // 
            this.clmnIsSubCategory.Caption = "Sub Category";
            this.clmnIsSubCategory.FieldName = "IsSubCategory";
            this.clmnIsSubCategory.MinWidth = 27;
            this.clmnIsSubCategory.Name = "clmnIsSubCategory";
            this.clmnIsSubCategory.OptionsColumn.AllowEdit = false;
            this.clmnIsSubCategory.OptionsColumn.ReadOnly = true;
            this.clmnIsSubCategory.Visible = true;
            this.clmnIsSubCategory.VisibleIndex = 2;
            this.clmnIsSubCategory.Width = 102;
            // 
            // clmnSubCategoryName
            // 
            this.clmnSubCategoryName.Caption = "Sub Category Name";
            this.clmnSubCategoryName.FieldName = "category.Name";
            this.clmnSubCategoryName.MinWidth = 27;
            this.clmnSubCategoryName.Name = "clmnSubCategoryName";
            this.clmnSubCategoryName.OptionsColumn.AllowEdit = false;
            this.clmnSubCategoryName.OptionsColumn.ReadOnly = true;
            this.clmnSubCategoryName.Visible = true;
            this.clmnSubCategoryName.VisibleIndex = 3;
            this.clmnSubCategoryName.Width = 102;
            // 
            // clmnEdit
            // 
            this.clmnEdit.Caption = "Edit";
            this.clmnEdit.ColumnEdit = this.lnkEdit;
            this.clmnEdit.MinWidth = 25;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Visible = true;
            this.clmnEdit.VisibleIndex = 4;
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
            this.clmnDelete.VisibleIndex = 5;
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
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtParentCategory);
            this.groupControl1.Location = new System.Drawing.Point(11, 25);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Employee Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(61, 235);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.ImageOptions.Image")));
            this.BtnClear.Location = new System.Drawing.Point(285, 235);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(102, 34);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(173, 235);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sub Category of :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 137);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.EditValue = "[Auto Generated]";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(149, 82);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 23);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 138);
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
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // txtParentCategory
            // 
            this.txtParentCategory.Location = new System.Drawing.Point(149, 188);
            this.txtParentCategory.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtParentCategory.Name = "txtParentCategory";
            this.txtParentCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtParentCategory.Properties.DisplayMember = "Name";
            this.txtParentCategory.Properties.NullText = "";
            this.txtParentCategory.Properties.PopupView = this.gridLookUpEdit1View;
            this.txtParentCategory.Properties.ValueMember = "Id";
            this.txtParentCategory.Size = new System.Drawing.Size(238, 23);
            this.txtParentCategory.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnParentId,
            this.clmnParentName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clmnParentId
            // 
            this.clmnParentId.Caption = "Id";
            this.clmnParentId.FieldName = "Id";
            this.clmnParentId.Name = "clmnParentId";
            this.clmnParentId.Visible = true;
            this.clmnParentId.VisibleIndex = 0;
            // 
            // clmnParentName
            // 
            this.clmnParentName.Caption = "Name";
            this.clmnParentName.FieldName = "Name";
            this.clmnParentName.Name = "clmnParentName";
            this.clmnParentName.Visible = true;
            this.clmnParentName.VisibleIndex = 1;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(735, 709);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCategories";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParentCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView GVCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn clmnId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnIsSubCategory;
        private DevExpress.XtraGrid.Columns.GridColumn clmnSubCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.GridLookUpEdit txtParentCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn clmnParentId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnParentName;
    }
}