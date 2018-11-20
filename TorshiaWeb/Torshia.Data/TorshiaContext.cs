namespace Torshia.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Torshia.Models;

    public class TorshiaContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }        

        public DbSet<Report> Reports { get; set; }

        public DbSet<TasksSectors> AffectedSectors{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server=.;Database=TorshiaDb;Integrated Security=True;");
            }
        }
    }
}
