﻿using Packt.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class Product
    {
      public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null;
        [Column("UnitPrice",TypeName ="money")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
