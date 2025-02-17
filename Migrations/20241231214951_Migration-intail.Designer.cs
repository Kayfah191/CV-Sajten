﻿// <auto-generated />
using CV_Sajten.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV_Sajten.Migrations
{
    [DbContext(typeof(DatabasContext))]
    [Migration("20241231214951_Migration-intail")]
    partial class Migrationintail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CV_Sajten.Models.Anvandare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BildAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isPrivat")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Anvandares");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BildAdress = "https://example.com/images/anna.jpg",
                            Email = "anna.andersson@example.com",
                            Namn = "Anna Andersson",
                            isPrivat = true
                        },
                        new
                        {
                            ID = 21,
                            BildAdress = "https://example.com/images/erik.jpg",
                            Email = "erik.svensson@example.com",
                            Namn = "Erik Svensson",
                            isPrivat = false
                        });
                });

            modelBuilder.Entity("CV_Sajten.Models.Cv", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnvandareID")
                        .HasColumnType("int");

                    b.Property<string>("Erfarenheter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kompetenser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Utbildning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AnvandareID");

                    b.ToTable("Cvs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AnvandareID = 1,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        });
                });

            modelBuilder.Entity("CV_Sajten.Models.Cv", b =>
                {
                    b.HasOne("CV_Sajten.Models.Anvandare", null)
                        .WithMany("Cvs")
                        .HasForeignKey("AnvandareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_Sajten.Models.Anvandare", b =>
                {
                    b.Navigation("Cvs");
                });
#pragma warning restore 612, 618
        }
    }
}
