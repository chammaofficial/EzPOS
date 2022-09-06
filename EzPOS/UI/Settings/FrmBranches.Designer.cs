namespace EzPOS.UI.Settings
{
    partial class FrmBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranches));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtContactNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GCBranches = new DevExpress.XtraGrid.GridControl();
            this.GVBranches = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAddress01 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAddress02 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.BtnClear);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtContactNo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtCity);
            this.groupControl1.Controls.Add(this.txtAddress1);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtAddress2);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtCode);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(842, 274);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Branch Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::EzPOS.Properties.Resources.refresh_32px;
            this.btnRefresh.Location = new System.Drawing.Point(439, 232);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.ImageOptions.Image = global::EzPOS.Properties.Resources.eraser_tool_32px;
            this.BtnClear.Location = new System.Drawing.Point(663, 232);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(102, 34);
            this.BtnClear.TabIndex = 31;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = global::EzPOS.Properties.Resources.save_32px;
            this.BtnSave.Location = new System.Drawing.Point(551, 232);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(102, 34);
            this.BtnSave.TabIndex = 30;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(496, 177);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 22);
            this.chkActive.TabIndex = 29;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(496, 100);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Properties.Appearance.Options.UseFont = true;
            this.txtContactNo.Size = new System.Drawing.Size(242, 24);
            this.txtContactNo.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(496, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(242, 24);
            this.txtEmail.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "City :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contact No :";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(496, 61);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Properties.Appearance.Options.UseFont = true;
            this.txtCity.Size = new System.Drawing.Size(242, 24);
            this.txtCity.TabIndex = 23;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(108, 139);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Properties.Appearance.Options.UseFont = true;
            this.txtAddress1.Size = new System.Drawing.Size(242, 24);
            this.txtAddress1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address 02 :";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(108, 178);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Properties.Appearance.Options.UseFont = true;
            this.txtAddress2.Size = new System.Drawing.Size(242, 24);
            this.txtAddress2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name :";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(108, 61);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Size = new System.Drawing.Size(242, 24);
            this.txtCode.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address 01 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 100);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(242, 24);
            this.txtName.TabIndex = 15;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.CaptionImageOptions.Image = global::EzPOS.Properties.Resources.list_view_48px;
            this.groupControl2.Controls.Add(this.GCBranches);
            this.groupControl2.Location = new System.Drawing.Point(12, 292);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(842, 274);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Branches List";
            // 
            // GCBranches
            // 
            this.GCBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCBranches.Location = new System.Drawing.Point(5, 60);
            this.GCBranches.MainView = this.GVBranches;
            this.GCBranches.Name = "GCBranches";
            this.GCBranches.Size = new System.Drawing.Size(830, 200);
            this.GCBranches.TabIndex = 0;
            this.GCBranches.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVBranches});
            // 
            // GVBranches
            // 
            this.GVBranches.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnCode,
            this.clmnName,
            this.clmnAddress01,
            this.clmnAddress02,
            this.clmnCity,
            this.clmnContactNo,
            this.clmnEmail,
            this.clmnIsActive});
            this.GVBranches.GridControl = this.GCBranches;
            this.GVBranches.Name = "GVBranches";
            // 
            // clmnCode
            // 
            this.clmnCode.Caption = "Code";
            this.clmnCode.FieldName = "Code";
            this.clmnCode.MinWidth = 25;
            this.clmnCode.Name = "clmnCode";
            this.clmnCode.Visible = true;
            this.clmnCode.VisibleIndex = 0;
            this.clmnCode.Width = 94;
            // 
            // clmnName
            // 
            this.clmnName.Caption = "Name";
            this.clmnName.FieldName = "Name";
            this.clmnName.MinWidth = 25;
            this.clmnName.Name = "clmnName";
            this.clmnName.Visible = true;
            this.clmnName.VisibleIndex = 1;
            this.clmnName.Width = 94;
            // 
            // clmnAddress01
            // 
            this.clmnAddress01.Caption = "Address 01";
            this.clmnAddress01.FieldName = "Address1";
            this.clmnAddress01.MinWidth = 25;
            this.clmnAddress01.Name = "clmnAddress01";
            this.clmnAddress01.Visible = true;
            this.clmnAddress01.VisibleIndex = 2;
            this.clmnAddress01.Width = 94;
            // 
            // clmnAddress02
            // 
            this.clmnAddress02.Caption = "Address 02";
            this.clmnAddress02.FieldName = "Address2";
            this.clmnAddress02.MinWidth = 25;
            this.clmnAddress02.Name = "clmnAddress02";
            this.clmnAddress02.Visible = true;
            this.clmnAddress02.VisibleIndex = 3;
            this.clmnAddress02.Width = 94;
            // 
            // clmnCity
            // 
            this.clmnCity.Caption = "City";
            this.clmnCity.FieldName = "City";
            this.clmnCity.MinWidth = 25;
            this.clmnCity.Name = "clmnCity";
            this.clmnCity.Visible = true;
            this.clmnCity.VisibleIndex = 4;
            this.clmnCity.Width = 94;
            // 
            // clmnContactNo
            // 
            this.clmnContactNo.Caption = "Contact No";
            this.clmnContactNo.FieldName = "ContactNumber";
            this.clmnContactNo.MinWidth = 25;
            this.clmnContactNo.Name = "clmnContactNo";
            this.clmnContactNo.Visible = true;
            this.clmnContactNo.VisibleIndex = 5;
            this.clmnContactNo.Width = 94;
            // 
            // clmnEmail
            // 
            this.clmnEmail.Caption = "Email";
            this.clmnEmail.FieldName = "EmailAddress";
            this.clmnEmail.MinWidth = 25;
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.Visible = true;
            this.clmnEmail.VisibleIndex = 6;
            this.clmnEmail.Width = 94;
            // 
            // clmnIsActive
            // 
            this.clmnIsActive.Caption = "Active";
            this.clmnIsActive.FieldName = "IsActive";
            this.clmnIsActive.MinWidth = 25;
            this.clmnIsActive.Name = "clmnIsActive";
            this.clmnIsActive.Visible = true;
            this.clmnIsActive.VisibleIndex = 7;
            this.clmnIsActive.Width = 94;
            // 
            // FrmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 575);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmBranches.IconOptions.SvgImage")));
            this.Name = "FrmBranches";
            this.Text = "Branches";
            this.Load += new System.EventHandler(this.FrmBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBranches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtAddress1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtAddress2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtContactNo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private System.Windows.Forms.CheckBox chkActive;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.GridControl GCBranches;
        private DevExpress.XtraGrid.Views.Grid.GridView GVBranches;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmnName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAddress01;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAddress02;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCity;
        private DevExpress.XtraGrid.Columns.GridColumn clmnContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn clmnIsActive;
    }
}