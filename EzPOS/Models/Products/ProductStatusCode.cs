using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzPOS.Models.Products
{
    public class ProductStatusCode
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
