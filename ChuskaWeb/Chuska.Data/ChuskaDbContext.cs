using Chuska.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;
namespace Chuska.Web.Data
{
    public class ChuskaDbContext : IdentityDbContext<ChuskaUser>
    {
        public ChuskaDbContext(DbContextOptions<ChuskaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
