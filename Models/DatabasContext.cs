using Microsoft.EntityFrameworkCore;

namespace CV_Sajten.Models
{
    public class DatabasContext: DbContext
    {

        public DatabasContext(DbContextOptions<DatabasContext> options) : base(options) { 
        
        
        }
        public DbSet<Anvandare> Anvandares { get; set; }
        public DbSet<Cv> Cvs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cv>().HasData(
                new Cv { });
               
            modelBuilder.Entity<Anvandare>().HasData(
                new Anvandare

                {

                });
        }
    }
}
