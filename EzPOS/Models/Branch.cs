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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MinLength(3)]
        [MaxLength(3)]
        [Key]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
