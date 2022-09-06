using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzPOS.Models;
using EzPOS.Services;

namespace EzPOS.UI.Settings
{
    public partial class FrmBusinessSettings : DevExpress.XtraEditors.XtraForm
    {
        private BranchService service;
        private Branch tempBranch;
        public FrmBusinessSettings()
        {
            InitializeComponent();
            service = new BranchService(new POSContext());
            tempBranch = service.GetBranchById(Session.LoginBranch.Id);
        }

        private void FrmBusinessSettings_Load(object sender, EventArgs e)
        {
            txtBusinessName.Text = tempBranch.BusinessSetting.Name;
            dteStartDate.EditValue = tempBranch.BusinessSetting.StartDate;
        }
    }
}
