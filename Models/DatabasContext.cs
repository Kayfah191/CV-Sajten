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
                new Cv {
                    ID = 1,
                    Kompetenser = "C#, .NET, SQL, Azure",
                    Utbildning = "Civilingenjör i Datateknik, KTH",
                    Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                    AnvandareID = 1
                });
               
            modelBuilder.Entity<Anvandare>().HasData(
                new Anvandare

                {
                    ID = 1,
                    Namn = "Anna Andersson",
                    Email = "anna.andersson@example.com",
                    isPrivat = true,
                    BildAdress = "https://example.com/images/anna.jpg",


                });
        }
    }
}
