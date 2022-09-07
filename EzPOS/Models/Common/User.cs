using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EzPOS.Models.Settings;

namespace EzPOS.Models.Common
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public List<Branch> Branches { get; set; }
    }
}
