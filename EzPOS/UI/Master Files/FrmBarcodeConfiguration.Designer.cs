namespace EzPOS.UI.Master_Files
{
    partial class FrmBarcodeConfiguration
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExpiring = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomBarcode = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReOrderLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtMaxOrderLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtModelNo = new DevExpress.XtraEditors.TextEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtBrand = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GVBrand = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMainCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GVMainCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnMainCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnMainCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSubCategory = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GVSubCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnsubcategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnsubcategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrderLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxOrderLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMainCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.barcode_32px;
            this.groupControl1.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.chkExpiring);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtCustomBarcode);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txtReOrderLevel);
            this.groupControl1.Controls.Add(this.txtMaxOrderLevel);
            this.groupControl1.Controls.Add(this.txtModelNo);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.txtBrand);
            this.groupControl1.Controls.Add(this.txtMainCategory);
            this.groupControl1.Controls.Add(this.txtSubCategory);
            this.groupControl1.Location = new System.Drawing.Point(16, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1149, 292);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Barcode Configuration Details";
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.Image = global::EzPOS.Properties.Resources.save_32px;
            this.btnPreview.Location = new System.Drawing.Point(704, 250);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(102, 34);
            this.btnPreview.TabIndex = 32;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Paper Height :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Paper Width :";
            // 
            // chkExpiring
            // 
            this.chkExpiring.AutoSize = true;
            this.chkExpiring.Location = new System.Drawing.Point(904, 83);
            this.chkExpiring.Name = "chkExpiring";
            this.chkExpiring.Size = new System.Drawing.Size(121, 20);
            this.chkExpiring.TabIndex = 7;
            this.chkExpiring.Text = "Expiring Product";
            this.chkExpiring.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(789, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Expire Status :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 197);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Custom Barcode :";
            // 
            // txtCustomBarcode
            // 
            this.txtCustomBarcode.Location = new System.Drawing.Point(904, 196);
            this.txtCustomBarcode.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCustomBarcode.Name = "txtCustomBarcode";
            this.txtCustomBarcode.Size = new System.Drawing.Size(238, 23);
            this.txtCustomBarcode.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Max Order Level :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(767, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Re - Order Level :";
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(904, 159);
            this.txtReOrderLevel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(238, 23);
            this.txtReOrderLevel.TabIndex = 9;
            // 
            // txtMaxOrderLevel
            // 
            this.txtMaxOrderLevel.Location = new System.Drawing.Point(904, 121);
            this.txtMaxOrderLevel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMaxOrderLevel.Name = "txtMaxOrderLevel";
            this.txtMaxOrderLevel.Size = new System.Drawing.Size(238, 23);
            this.txtMaxOrderLevel.TabIndex = 8;
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(482, 157);
            this.txtModelNo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(238, 23);
            this.txtModelNo.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(816, 250);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = global::EzPOS.Properties.Resources.eraser_tool_32px;
            this.BtnClear.Location = new System.Drawing.Point(1040, 250);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(102, 34);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = global::EzPOS.Properties.Resources.save_32px;
            this.BtnSave.Location = new System.Drawing.Point(928, 250);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Paper Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Paper Type :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 120);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.EditValue = "[Auto Generated]";
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(120, 82);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(238, 23);
            this.txtId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 121);
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
            this.label1.Location = new System.Drawing.Point(77, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 157);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(238, 23);
            this.txtDescription.TabIndex = 1;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(120, 196);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBrand.Properties.DisplayMember = "Name";
            this.txtBrand.Properties.NullText = "";
            this.txtBrand.Properties.PopupView = this.GVBrand;
            this.txtBrand.Properties.ValueMember = "Id";
            this.txtBrand.Size = new System.Drawing.Size(238, 23);
            this.txtBrand.TabIndex = 2;
            // 
            // GVBrand
            // 
            this.GVBrand.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnBrandId,
            this.clmnBrandName});
            this.GVBrand.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVBrand.Name = "GVBrand";
            this.GVBrand.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GVBrand.OptionsView.ShowGroupPanel = false;
            // 
            // clmnBrandId
            // 
            this.clmnBrandId.Caption = "Id";
            this.clmnBrandId.FieldName = "Id";
            this.clmnBrandId.Name = "clmnBrandId";
            // 
            // clmnBrandName
            // 
            this.clmnBrandName.Caption = "Name";
            this.clmnBrandName.FieldName = "Name";
            this.clmnBrandName.Name = "clmnBrandName";
            this.clmnBrandName.Visible = true;
            this.clmnBrandName.VisibleIndex = 0;
            // 
            // txtMainCategory
            // 
            this.txtMainCategory.Location = new System.Drawing.Point(482, 82);
            this.txtMainCategory.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMainCategory.Name = "txtMainCategory";
            this.txtMainCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMainCategory.Properties.DisplayMember = "Name";
            this.txtMainCategory.Properties.NullText = "";
            this.txtMainCategory.Properties.PopupView = this.GVMainCategory;
            this.txtMainCategory.Properties.ValueMember = "Id";
            this.txtMainCategory.Size = new System.Drawing.Size(238, 23);
            this.txtMainCategory.TabIndex = 3;
            // 
            // GVMainCategory
            // 
            this.GVMainCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnMainCategoryId,
            this.clmnMainCategoryName});
            this.GVMainCategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVMainCategory.Name = "GVMainCategory";
            this.GVMainCategory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GVMainCategory.OptionsView.ShowGroupPanel = false;
            // 
            // clmnMainCategoryId
            // 
            this.clmnMainCategoryId.Caption = "Id";
            this.clmnMainCategoryId.FieldName = "Id";
            this.clmnMainCategoryId.Name = "clmnMainCategoryId";
            // 
            // clmnMainCategoryName
            // 
            this.clmnMainCategoryName.Caption = "Name";
            this.clmnMainCategoryName.FieldName = "Name";
            this.clmnMainCategoryName.Name = "clmnMainCategoryName";
            this.clmnMainCategoryName.Visible = true;
            this.clmnMainCategoryName.VisibleIndex = 0;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(482, 120);
            this.txtSubCategory.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSubCategory.Properties.DisplayMember = "Name";
            this.txtSubCategory.Properties.NullText = "";
            this.txtSubCategory.Properties.PopupView = this.GVSubCategory;
            this.txtSubCategory.Properties.ValueMember = "Id";
            this.txtSubCategory.Size = new System.Drawing.Size(238, 23);
            this.txtSubCategory.TabIndex = 4;
            // 
            // GVSubCategory
            // 
            this.GVSubCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnsubcategoryId,
            this.clmnsubcategoryName});
            this.GVSubCategory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVSubCategory.Name = "GVSubCategory";
            this.GVSubCategory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GVSubCategory.OptionsView.ShowGroupPanel = false;
            // 
            // clmnsubcategoryId
            // 
            this.clmnsubcategoryId.Caption = "Id";
            this.clmnsubcategoryId.FieldName = "Id";
            this.clmnsubcategoryId.Name = "clmnsubcategoryId";
            // 
            // clmnsubcategoryName
            // 
            this.clmnsubcategoryName.Caption = "Name";
            this.clmnsubcategoryName.FieldName = "Name";
            this.clmnsubcategoryName.Name = "clmnsubcategoryName";
            this.clmnsubcategoryName.Visible = true;
            this.clmnsubcategoryName.VisibleIndex = 0;
            // 
            // FrmBarcodeConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 588);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBarcodeConfiguration";
            this.Text = "Barcode Configurations";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrderLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxOrderLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMainCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox chkExpiring;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtCustomBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtReOrderLevel;
        private DevExpress.XtraEditors.TextEdit txtMaxOrderLevel;
        private DevExpress.XtraEditors.TextEdit txtModelNo;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.GridLookUpEdit txtBrand;
        private DevExpress.XtraGrid.Views.Grid.GridView GVBrand;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBrandId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBrandName;
        private DevExpress.XtraEditors.GridLookUpEdit txtMainCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView GVMainCategory;
        private DevExpress.XtraGrid.Columns.GridColumn clmnMainCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnMainCategoryName;
        private DevExpress.XtraEditors.GridLookUpEdit txtSubCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView GVSubCategory;
        private DevExpress.XtraGrid.Columns.GridColumn clmnsubcategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnsubcategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}