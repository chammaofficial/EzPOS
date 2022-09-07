using System;
using System.ComponentModel.DataAnnotations;

namespace EzPOS.Models.Products
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        public bool IsSubCategory { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category category { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
