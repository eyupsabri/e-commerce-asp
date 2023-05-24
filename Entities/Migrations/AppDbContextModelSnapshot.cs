﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Elektronik"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Tuvalet Kağıdı"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gazete"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Telefon"
                        });
                });

            modelBuilder.Entity("Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems", (string)null);
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 4,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Samsung-s20",
                            ProductPrice = 10550.6
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Hoparlor",
                            ProductPrice = 500.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Selpak",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 3,
                            ProductDescription = "Cok ucuz",
                            ProductName = "Sozcu",
                            ProductPrice = 2.0
                        });
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.HasOne("Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.OrderItem", b =>
                {
                    b.HasOne("Entities.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.HasOne("Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
