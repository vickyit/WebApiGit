using Microsoft.EntityFrameworkCore;
using WebApiClass.Models;

namespace WebApiClass.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

    }
}
