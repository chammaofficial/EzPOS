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
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
