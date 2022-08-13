namespace EzPOS.UI.Common
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtBranch = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glBranches = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(227, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(168, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(136, 110);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBranch.Properties.DisplayMember = "Name";
            this.txtBranch.Properties.NullText = "";
            this.txtBranch.Properties.PopupView = this.glBranches;
            this.txtBranch.Properties.ValueMember = "Code";
            this.txtBranch.Size = new System.Drawing.Size(227, 23);
            this.txtBranch.TabIndex = 5;
            // 
            // glBranches
            // 
            this.glBranches.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnBranchCode,
            this.clmnBranchName});
            this.glBranches.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glBranches.Name = "glBranches";
            this.glBranches.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glBranches.OptionsView.ShowGroupPanel = false;
            // 
            // clmnBranchCode
            // 
            this.clmnBranchCode.Caption = "Branch Code";
            this.clmnBranchCode.FieldName = "Code";
            this.clmnBranchCode.Name = "clmnBranchCode";
            this.clmnBranchCode.Visible = true;
            this.clmnBranchCode.VisibleIndex = 0;
            // 
            // clmnBranchName
            // 
            this.clmnBranchName.Caption = "Branch Name";
            this.clmnBranchName.FieldName = "Name";
            this.clmnBranchName.Name = "clmnBranchName";
            this.clmnBranchName.Visible = true;
            this.clmnBranchName.VisibleIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 205);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBranch);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - EzPOS";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glBranches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.GridLookUpEdit txtBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView glBranches;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBranchName;
    }
}