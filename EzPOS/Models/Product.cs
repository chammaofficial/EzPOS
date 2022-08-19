﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using EzPOS.Migrations;

namespace EzPOS.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public  virtual Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public virtual Category Category { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category SubCategory { get; set; }
        public int? SubCategoryId { get; set; }
        public string ModelNo { get; set; }
        public bool HasSerial { get; set; }
        public bool IsExpiring { get; set; }
        public decimal ReOrderLevel { get; set; }

        public decimal MaxOrderLevel { get; set; }

        [StringLength(20)]
        [Index(IsUnique = true)]
        public string CustomBarcode { get; set; }
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
