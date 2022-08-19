using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace EzPOS.UI.Master_Files
{
    public partial class FrmReportViewer : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rpt;
        public FrmReportViewer()
        {
            InitializeComponent();
        }

        public FrmReportViewer(object rpt)
        {
            InitializeComponent();
            rpt = (XtraReport)rpt;
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = rpt;
            documentViewer1.Show();
        }
    }
}
