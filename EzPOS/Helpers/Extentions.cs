using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Helpers
{
    public static class Extentions
    {
        public static void Clear(this TextEdit Field)
        {
            Field.Text = "";
        }

        public static byte[] ConvertToByteArray(this System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static Image ConvertToImage(this byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }

        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        public static decimal ToDecimal(this string s,int precision)
        {
            return decimal.Parse(s);
        }
    }
}
