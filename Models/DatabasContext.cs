using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CV_Sajten.Models
{
    public class DatabasContext : DbContext
    {
        public DatabasContext(DbContextOptions<DatabasContext> options) : base(options) { }

        public DbSet<Anvandare> Anvandares { get; set; }
        public DbSet<Cv> Cvs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          

            // Data för Anvandare
            modelBuilder.Entity<Anvandare>().HasData(
                new Anvandare
                {
                    ID = 1,
                    Namn = "Anna Andersson",
                    Email = "anna.andersson@example.com",
                    Losenord="hej1",
                    isPrivat = true,
                    BildAdress = "https://example.com/images/anna.jpg"
                },
                new Anvandare
                {
                    ID = 21,
                    Namn = "Erik Svensson",
                    Email = "erik.svensson@example.com",
                    Losenord = "hej2",
                    isPrivat = false,
                    BildAdress = "https://example.com/images/erik.jpg"
                }
            );
            // Data för Cv
            modelBuilder.Entity<Cv>().HasData(
                new Cv
                {
                    Id = 1,
                    Kompetenser = "C#, .NET, SQL, Azure",
                    Utbildning = "Civilingenjör i Datateknik, KTH",
                    Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                    AnvandareID = 1
                },
                  new Cv
                  {
                      Id = 2,
                      Kompetenser = "C#, .NET, SQL, Azure",
                      Utbildning = "Civilingenjör i Datateknik, KTH",
                      Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                      AnvandareID = 21
                  }

            );
        }
    }
}
