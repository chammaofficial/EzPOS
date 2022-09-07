using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EzPOS.Helpers;


namespace EzPOS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(12)]
        [Index(IsUnique = true)]
        public string Nic { get; set; }

        [StringLength(500)]

        public string Email { get; set; }

        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Required]
        public Boolean IsActive { get; set; }

        public virtual Branch Branch { get; set; }

        public int BranchId { get; set; }

    }
}
