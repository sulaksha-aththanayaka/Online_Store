using System;
using Store.Models;
using Microsoft.EntityFrameworkCore;
using OnlineStore;

namespace Store
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
    : base(options) { }

        public DbSet<Customer> Customers { get; set; } = null;

        public DbSet<OnlineStore.Order> Order { get; set; } = default!;

        public DbSet<OnlineStore.Product> Product { get; set; } = default!;

        public DbSet<OnlineStore.Category> Category { get; set; } = default!;


    }
}
 





