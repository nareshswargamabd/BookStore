using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        { 
        }
        public DbSet<Books> Book { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
