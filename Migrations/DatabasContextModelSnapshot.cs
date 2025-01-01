﻿// <auto-generated />
using System;
using CV_Sajten.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV_Sajten.Migrations
{
    [DbContext(typeof(DatabasContext))]
    partial class DatabasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Losenord")
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
                            Losenord = "hej1",
                            Namn = "Anna Andersson",
                            isPrivat = true
                        },
                        new
                        {
                            ID = 21,
                            BildAdress = "https://example.com/images/erik.jpg",
                            Email = "erik.svensson@example.com",
                            Losenord = "hej2",
                            Namn = "Erik Svensson",
                            isPrivat = false
                        });
                });

            modelBuilder.Entity("CV_Sajten.Models.Cv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasKey("Id");

                    b.HasIndex("AnvandareID");

                    b.ToTable("Cvs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnvandareID = 1,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        },
                        new
                        {
                            Id = 2,
                            AnvandareID = 21,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        },
                        new
                        {
                            Id = 3,
                            AnvandareID = 1,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        },
                        new
                        {
                            Id = 4,
                            AnvandareID = 1,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        },
                        new
                        {
                            Id = 5,
                            AnvandareID = 1,
                            Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                            Kompetenser = "C#, .NET, SQL, Azure",
                            Utbildning = "Civilingenjör i Datateknik, KTH"
                        });
                });

            modelBuilder.Entity("CV_Sajten.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CV_Sajten.Models.Cv", b =>
                {
                    b.HasOne("CV_Sajten.Models.Anvandare", "Anvandare")
                        .WithMany("Cvs")
                        .HasForeignKey("AnvandareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anvandare");
                });

            modelBuilder.Entity("CV_Sajten.Models.Anvandare", b =>
                {
                    b.Navigation("Cvs");
                });
#pragma warning restore 612, 618
        }
    }
}
