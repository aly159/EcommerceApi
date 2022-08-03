
using ECommerceApiVersion1.Tables;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ECommerceApiVersion1.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Users> users { get; set; }
    }
}
