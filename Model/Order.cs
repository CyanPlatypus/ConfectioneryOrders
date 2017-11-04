using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConfectioneryOrders.Model
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public Client Client { get; set; }

        [Required]
        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        public Vendor Vendor { get; set; }
        
        [NotMapped]
        public string ClientName {
            get { return Client?.Name; }
        }
        [NotMapped]
        public string VendorName {
            get { return Vendor?.Name; }
        }

        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }
    }
}
