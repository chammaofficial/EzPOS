using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;

namespace EzPOS.Migrations
{
    public class ProductSerial
    {
        [Key]
        public int Id { get; set; }
        public string Serial { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
