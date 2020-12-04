using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Lab5.Models
{
    public class Order
    {
        public int orderID { get; set; }

        public DateTime dateOrderPlaced { get; set; }

        public DateTime dateOrderPaid { get; set; }

        public string paymentMethod { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int CustomerFK { get; set; }

        
    }
}
