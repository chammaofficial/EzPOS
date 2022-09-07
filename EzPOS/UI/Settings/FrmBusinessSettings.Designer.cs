namespace EzPOS.UI.Settings
{
    partial class FrmBusinessSettings
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
            this.components = new System.ComponentModel.Container();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransactionEditDays = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDefaultProfitPrecentage = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusinessName = new DevExpress.XtraEditors.TextEdit();
            this.dteStartDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCurrencySymbolPlacement = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnCurrencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCurrencySymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFinancialYearStartMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtStockAccountingMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDateFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionEditDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultProfitPrecentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencySymbolPlacement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinancialYearStartMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockAccountingMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFormat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            this.xtraOpenFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG";
            this.xtraOpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.xtraOpenFileDialog1_FileOk);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.Business_settings_32;
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.btnUpload);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtTransactionEditDays);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtDefaultProfitPrecentage);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtBusinessName);
            this.groupControl1.Controls.Add(this.dteStartDate);
            this.groupControl1.Controls.Add(this.txtCurrencySymbolPlacement);
            this.groupControl1.Controls.Add(this.txtCurrency);
            this.groupControl1.Controls.Add(this.txtFinancialYearStartMonth);
            this.groupControl1.Controls.Add(this.txtStockAccountingMethod);
            this.groupControl1.Controls.Add(this.txtDateFormat);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1419, 439);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Business Settings";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.ImageOptions.Image = global::EzPOS.Properties.Resources.save_32px;
            this.BtnSave.Location = new System.Drawing.Point(1310, 397);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 30;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.ImageOptions.Image = global::EzPOS.Properties.Resources.upload_32px___Copy;
            this.btnUpload.Location = new System.Drawing.Point(233, 169);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(102, 34);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EzPOS.Properties.Resources.image_placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(32, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Upload Logo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(889, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Transactions Edit Days :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(955, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date Format :";
            // 
            // txtTransactionEditDays
            // 
            this.txtTransactionEditDays.Location = new System.Drawing.Point(1061, 67);
            this.txtTransactionEditDays.Name = "txtTransactionEditDays";
            this.txtTransactionEditDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionEditDays.Properties.Appearance.Options.UseFont = true;
            this.txtTransactionEditDays.Size = new System.Drawing.Size(242, 24);
            this.txtTransactionEditDays.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Currency Symbol Placement :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Currency :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(874, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Accounting Method :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Default Profit Precentage :";
            // 
            // txtDefaultProfitPrecentage
            // 
            this.txtDefaultProfitPrecentage.Location = new System.Drawing.Point(583, 118);
            this.txtDefaultProfitPrecentage.Name = "txtDefaultProfitPrecentage";
            this.txtDefaultProfitPrecentage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultProfitPrecentage.Properties.Appearance.Options.UseFont = true;
            this.txtDefaultProfitPrecentage.Size = new System.Drawing.Size(242, 24);
            this.txtDefaultProfitPrecentage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Financial Year Start Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Business Name :";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(583, 67);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessName.Properties.Appearance.Options.UseFont = true;
            this.txtBusinessName.Size = new System.Drawing.Size(242, 24);
            this.txtBusinessName.TabIndex = 0;
            // 
            // dteStartDate
            // 
            this.dteStartDate.EditValue = null;
            this.dteStartDate.Location = new System.Drawing.Point(583, 216);
            this.dteStartDate.Name = "dteStartDate";
            this.dteStartDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteStartDate.Properties.Appearance.Options.UseFont = true;
            this.dteStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDate.Properties.DisplayFormat.FormatString = "";
            this.dteStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStartDate.Properties.EditFormat.FormatString = "";
            this.dteStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteStartDate.Properties.MaskSettings.Set("mask", "");
            this.dteStartDate.Size = new System.Drawing.Size(242, 24);
            this.dteStartDate.TabIndex = 12;
            // 
            // txtCurrencySymbolPlacement
            // 
            this.txtCurrencySymbolPlacement.Location = new System.Drawing.Point(583, 169);
            this.txtCurrencySymbolPlacement.Name = "txtCurrencySymbolPlacement";
            this.txtCurrencySymbolPlacement.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencySymbolPlacement.Properties.Appearance.Options.UseFont = true;
            this.txtCurrencySymbolPlacement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCurrencySymbolPlacement.Properties.Items.AddRange(new object[] {
            "Before Amount",
            "After Amount"});
            this.txtCurrencySymbolPlacement.Size = new System.Drawing.Size(242, 24);
            this.txtCurrencySymbolPlacement.TabIndex = 4;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(583, 267);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.Properties.Appearance.Options.UseFont = true;
            this.txtCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCurrency.Properties.DisplayMember = "Symbol";
            this.txtCurrency.Properties.NullText = "";
            this.txtCurrency.Properties.PopupView = this.gridView2;
            this.txtCurrency.Properties.ValueMember = "Id";
            this.txtCurrency.Size = new System.Drawing.Size(242, 24);
            this.txtCurrency.TabIndex = 8;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnCurrencyId,
            this.clmnCurrencyName,
            this.clmnCurrencySymbol});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // clmnCurrencyId
            // 
            this.clmnCurrencyId.Caption = "Id";
            this.clmnCurrencyId.FieldName = "Id";
            this.clmnCurrencyId.Name = "clmnCurrencyId";
            // 
            // clmnCurrencyName
            // 
            this.clmnCurrencyName.Caption = "Name";
            this.clmnCurrencyName.FieldName = "Name";
            this.clmnCurrencyName.Name = "clmnCurrencyName";
            this.clmnCurrencyName.Visible = true;
            this.clmnCurrencyName.VisibleIndex = 0;
            // 
            // clmnCurrencySymbol
            // 
            this.clmnCurrencySymbol.Caption = "Symbol";
            this.clmnCurrencySymbol.FieldName = "Symbol";
            this.clmnCurrencySymbol.Name = "clmnCurrencySymbol";
            this.clmnCurrencySymbol.Visible = true;
            this.clmnCurrencySymbol.VisibleIndex = 1;
            // 
            // txtFinancialYearStartMonth
            // 
            this.txtFinancialYearStartMonth.Location = new System.Drawing.Point(1061, 219);
            this.txtFinancialYearStartMonth.Name = "txtFinancialYearStartMonth";
            this.txtFinancialYearStartMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinancialYearStartMonth.Properties.Appearance.Options.UseFont = true;
            this.txtFinancialYearStartMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFinancialYearStartMonth.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtFinancialYearStartMonth.Size = new System.Drawing.Size(242, 24);
            this.txtFinancialYearStartMonth.TabIndex = 14;
            // 
            // txtStockAccountingMethod
            // 
            this.txtStockAccountingMethod.Location = new System.Drawing.Point(1061, 169);
            this.txtStockAccountingMethod.Name = "txtStockAccountingMethod";
            this.txtStockAccountingMethod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAccountingMethod.Properties.Appearance.Options.UseFont = true;
            this.txtStockAccountingMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStockAccountingMethod.Properties.Items.AddRange(new object[] {
            "FIFO - First in First out",
            "LIFO - Last in First out"});
            this.txtStockAccountingMethod.Size = new System.Drawing.Size(242, 24);
            this.txtStockAccountingMethod.TabIndex = 10;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(1061, 118);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFormat.Properties.Appearance.Options.UseFont = true;
            this.txtDateFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFormat.Properties.Items.AddRange(new object[] {
            "YYYY-mm-dd",
            "dd-mm-YYYY",
            "YY-mm-dd",
            "dd-mm-YY",
            "YYYY-MMM-dd",
            "dd-MMM-YYYY"});
            this.txtDateFormat.Properties.PopupSizeable = true;
            this.txtDateFormat.Size = new System.Drawing.Size(242, 24);
            this.txtDateFormat.TabIndex = 24;
            // 
            // FrmBusinessSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 463);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::EzPOS.Properties.Resources.Business_settings_32;
            this.Name = "FrmBusinessSettings";
            this.Text = "Business Settings";
            this.Load += new System.EventHandler(this.FrmBusinessSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionEditDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultProfitPrecentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencySymbolPlacement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinancialYearStartMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockAccountingMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFormat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBusinessName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtTransactionEditDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtDefaultProfitPrecentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraEditors.DateEdit dteStartDate;
        private DevExpress.XtraEditors.ComboBoxEdit txtCurrencySymbolPlacement;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.GridLookUpEdit txtCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.ComboBoxEdit txtFinancialYearStartMonth;
        private DevExpress.XtraEditors.ComboBoxEdit txtStockAccountingMethod;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCurrencyId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCurrencySymbol;
        private DevExpress.XtraEditors.ComboBoxEdit txtDateFormat;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}