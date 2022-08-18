using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzPOS.Helpers
{
    public static class Alerts
    {
        public static void Error(string text)
        {
            MessageBox.Show(text,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Info(string text)
        {
            MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirm(string text)
        {
            return MessageBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
