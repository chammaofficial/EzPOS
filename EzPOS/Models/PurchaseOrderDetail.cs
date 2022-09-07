using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models.Products;

namespace EzPOS.Models
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public decimal OrderQty { get; set; }

        [Required] 
        public decimal ReceivedQty { get; set; }
        
        [Required]
        public decimal BalanceQty { get; set; }
        
        [Required]
        public int LineItemNo { get; set; }

        public string Remark { get; set; }

        [Required]
        public string Status { get; set; }
        
        [Required]
        public bool IsActive { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public int PurchaseOrderId { get; set; }
    }
}
