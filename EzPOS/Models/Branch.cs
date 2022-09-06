using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Models
{
    
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(5)]
        [Required]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
