using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Lab5.Models
{
    public class Customer
    {
        public int customerId { get; set; }

        public string name { get; set; }

        [Column(TypeName = "Date")]
        public DateTime dateOfPurchase { get; set; }

        public string itemPurchased { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }



    }
}
