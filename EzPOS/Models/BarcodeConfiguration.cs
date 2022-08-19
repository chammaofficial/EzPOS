using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Models
{
    public class BarcodeConfiguration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PaperType { get; set; }

        public decimal PaperHeight { get; set; }
        public decimal PaperWidth { get; set; }
        public decimal PaperTopMargin { get; set; }
        public decimal PaperBottomMargin { get; set; }
        public decimal PaperLeftMargin { get; set; }
        public decimal PaperRightMargin { get; set; }

        public decimal LabelHeight { get; set; }
        public decimal LabelWidth { get; set; }
        public decimal LabelTopMargin { get; set; }
        public decimal LabelBottomMargin { get; set; }
        public decimal LabelLeftMargin { get; set; }
        public decimal LabelRightMargin { get; set; }
        public decimal SpaceBetweenTwoLabelRows { get; set; }
        public decimal SpaceBetweenTwoLabelColumns { get; set; }

        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public bool BoldBusinessName { get; set; }
        public string DefaultFontName { get; set; }
        public decimal DefaultFontSize { get; set; }
    }
}
