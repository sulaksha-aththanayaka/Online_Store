using System;
using Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Store
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
    : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; } = null;
    }
}
 





