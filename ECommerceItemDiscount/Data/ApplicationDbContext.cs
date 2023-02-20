using ECommerceItemDiscount.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ECommerceItemDiscount.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<DiscountModel> Discounts { get; set; }      
        public DbSet<UserModel> Users { get; set; }
    }
}
