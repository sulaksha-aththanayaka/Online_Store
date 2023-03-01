using System;
using System.ComponentModel.DataAnnotations;
using Store.Models;

namespace Store.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

       // public ICollection<Order> Orders { get; set; }
    }
}


