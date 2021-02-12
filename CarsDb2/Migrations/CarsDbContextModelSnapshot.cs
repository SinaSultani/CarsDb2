﻿// <auto-generated />
using CarsDb2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarsDb2.Migrations
{
    [DbContext(typeof(CarsDbContext))]
    partial class CarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDealerCity", b =>
                {
                    b.Property<int>("CarDealersId")
                        .HasColumnType("int");

                    b.Property<int>("CitiesId")
                        .HasColumnType("int");

                    b.HasKey("CarDealersId", "CitiesId");

                    b.HasIndex("CitiesId");

                    b.ToTable("CarDealerCity");
                });

            modelBuilder.Entity("CarsDb2.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarDealerId")
                        .HasColumnType("int");

                    b.Property<string>("EngineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Motor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarDealerId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarsDb2.Models.CarDealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarDealers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hedin Bil"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bosses Bilar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bilia"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Platinum Cars"
                        });
                });

            modelBuilder.Entity("CarsDb2.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Malmö"
                        });
                });

            modelBuilder.Entity("CarsDb2.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Volvo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tesla"
                        });
                });

            modelBuilder.Entity("CarDealerCity", b =>
                {
                    b.HasOne("CarsDb2.Models.CarDealer", null)
                        .WithMany()
                        .HasForeignKey("CarDealersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsDb2.Models.City", null)
                        .WithMany()
                        .HasForeignKey("CitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarsDb2.Models.Car", b =>
                {
                    b.HasOne("CarsDb2.Models.CarDealer", "Dealer")
                        .WithMany("Cars")
                        .HasForeignKey("CarDealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsDb2.Models.Manufacturer", "Manufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dealer");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("CarsDb2.Models.CarDealer", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarsDb2.Models.Manufacturer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
