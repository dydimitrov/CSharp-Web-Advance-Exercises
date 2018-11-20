namespace IRunesAplication.Data
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class IRunesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Album> Albums { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

            string connectionString = @"Server=.;Database=IRunesDb;Integrated Security=True";

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(builder);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
        }


    }
}
