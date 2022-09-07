using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPOS.Models;
using EzPOS.Models.Products;

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
