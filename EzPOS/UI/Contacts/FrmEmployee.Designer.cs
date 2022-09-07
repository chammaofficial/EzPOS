namespace EzPOS.UI.Contacts
{
    partial class FrmEmployee
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GCEmployee = new DevExpress.XtraGrid.GridControl();
            this.GVEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnNic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.clmnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lnkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNic = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
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
            this.groupControl2.Controls.Add(this.GCEmployee);
            this.groupControl2.Location = new System.Drawing.Point(11, 330);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(711, 359);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Employee List";
            // 
            // GCEmployee
            // 
            this.GCEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCEmployee.Location = new System.Drawing.Point(2, 41);
            this.GCEmployee.MainView = this.GVEmployee;
            this.GCEmployee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GCEmployee.Name = "GCEmployee";
            this.GCEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lnkEdit,
            this.lnkDelete});
            this.GCEmployee.Size = new System.Drawing.Size(707, 316);
            this.GCEmployee.TabIndex = 0;
            this.GCEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVEmployee});
            // 
            // GVEmployee
            // 
            this.GVEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnId,
            this.clmnName,
            this.clmnAddress,
            this.clmnMobile,
            this.clmnNic,
            this.clmnEmail,
            this.clmnBranch,
            this.clmnEdit,
            this.clmnDelete});
            this.GVEmployee.DetailHeight = 546;
            this.GVEmployee.GridControl = this.GCEmployee;
            this.GVEmployee.Name = "GVEmployee";
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
            // clmnAddress
            // 
            this.clmnAddress.Caption = "Address";
            this.clmnAddress.FieldName = "Address";
            this.clmnAddress.MinWidth = 27;
            this.clmnAddress.Name = "clmnAddress";
            this.clmnAddress.OptionsColumn.AllowEdit = false;
            this.clmnAddress.OptionsColumn.ReadOnly = true;
            this.clmnAddress.Visible = true;
            this.clmnAddress.VisibleIndex = 2;
            this.clmnAddress.Width = 102;
            // 
            // clmnMobile
            // 
            this.clmnMobile.Caption = "Mobile";
            this.clmnMobile.FieldName = "Mobile";
            this.clmnMobile.MinWidth = 27;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.OptionsColumn.AllowEdit = false;
            this.clmnMobile.OptionsColumn.ReadOnly = true;
            this.clmnMobile.Visible = true;
            this.clmnMobile.VisibleIndex = 3;
            this.clmnMobile.Width = 102;
            // 
            // clmnNic
            // 
            this.clmnNic.Caption = "Nic";
            this.clmnNic.FieldName = "Nic";
            this.clmnNic.MinWidth = 27;
            this.clmnNic.Name = "clmnNic";
            this.clmnNic.OptionsColumn.AllowEdit = false;
            this.clmnNic.OptionsColumn.ReadOnly = true;
            this.clmnNic.Visible = true;
            this.clmnNic.VisibleIndex = 4;
            this.clmnNic.Width = 102;
            // 
            // clmnEmail
            // 
            this.clmnEmail.Caption = "Email";
            this.clmnEmail.FieldName = "Email";
            this.clmnEmail.MinWidth = 27;
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.OptionsColumn.AllowEdit = false;
            this.clmnEmail.OptionsColumn.ReadOnly = true;
            this.clmnEmail.Visible = true;
            this.clmnEmail.VisibleIndex = 5;
            this.clmnEmail.Width = 102;
            // 
            // clmnBranch
            // 
            this.clmnBranch.Caption = "Branch";
            this.clmnBranch.FieldName = "Branch.Name";
            this.clmnBranch.MinWidth = 27;
            this.clmnBranch.Name = "clmnBranch";
            this.clmnBranch.OptionsColumn.AllowEdit = false;
            this.clmnBranch.OptionsColumn.ReadOnly = true;
            this.clmnBranch.Visible = true;
            this.clmnBranch.VisibleIndex = 6;
            this.clmnBranch.Width = 102;
            // 
            // clmnEdit
            // 
            this.clmnEdit.Caption = "Edit";
            this.clmnEdit.ColumnEdit = this.lnkEdit;
            this.clmnEdit.MinWidth = 25;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Visible = true;
            this.clmnEdit.VisibleIndex = 7;
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
            this.clmnDelete.VisibleIndex = 8;
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
            this.groupControl1.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.Employee_32px;
            this.groupControl1.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.txtNic);
            this.groupControl1.Controls.Add(this.txtMobile);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Location = new System.Drawing.Point(11, 25);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Employee Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(354, 225);
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
            this.BtnClear.Location = new System.Drawing.Point(578, 225);
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
            this.BtnSave.Location = new System.Drawing.Point(466, 225);
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
            this.label6.Location = new System.Drawing.Point(351, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nic :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(407, 188);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(407, 137);
            this.txtNic.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(273, 23);
            this.txtNic.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(407, 82);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(273, 23);
            this.txtMobile.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 137);
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
            this.label2.Location = new System.Drawing.Point(27, 138);
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
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 190);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 23);
            this.txtAddress.TabIndex = 1;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(735, 709);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::EzPOS.Properties.Resources.Employee_32px;
            this.Name = "FrmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView GVEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn clmnId;
        private DevExpress.XtraGrid.Columns.GridColumn clmnName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn clmnMobile;
        private DevExpress.XtraGrid.Columns.GridColumn clmnNic;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBranch;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lnkDelete;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}