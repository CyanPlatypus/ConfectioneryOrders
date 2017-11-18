using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfectioneryOrders.Model
{
    public class VendorProduct
    {
        public int ID { get; set; }
        
        public int Quantity { get; set; }

        [Required]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        public Vendor Vendor { get; set; }

        [Required]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [NotMapped]
        public string ProductName {
            get { return Product?.Name; }
        }
    }
}
