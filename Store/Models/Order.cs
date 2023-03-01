using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Store.Models;

namespace OnlineStore
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       // public ICollection<Product> Products { get; set; }
    }
}

