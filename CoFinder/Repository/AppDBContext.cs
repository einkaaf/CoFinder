using CoFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace CoFinder.Repository
{
    public class AppDBContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AppDBContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

       public DbSet<Company> companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Server"));

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}
