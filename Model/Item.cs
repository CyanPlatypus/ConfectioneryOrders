﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfectioneryOrders.Model
{
    public class Item
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        [Required]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        
        [NotMapped]
        public string ProductName {
            get { return Product?.Name; }
        }

        [Required]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
    }
}
