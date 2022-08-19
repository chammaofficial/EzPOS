using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.Native.DataFederation.QueryBuilder;


namespace EzPOS.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PoDate { get; set; }

        public Supplier Supplier { get; set; }

        [Required]
        public int SupplierId { get; set; }

        public DateTime? DeliveryDate  { get; set; }

        public string Remark { get; set; }

        public string Status { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Branch Branch { get; set; }

        public IEnumerable<PurchaseOrderDetail> Details { get; set; }

        [Required]
        public int BranchId { get; set; }

    }
}
