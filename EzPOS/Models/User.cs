using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Key]
        [StringLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public List<Branch> Branches { get; set; }
    }
}
