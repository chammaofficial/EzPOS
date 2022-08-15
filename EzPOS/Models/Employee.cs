using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


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
        public string Nic { get; set; }

        [StringLength(500)]

        public string Email { get; set; }

        public Branch Branch { get; set; }

        public int BranchId { get; set; }

    }
}
