﻿// <auto-generated />
using System;
using InterwayAPI.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interway.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("InvoiceStatusId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceStatusId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.InvoiceLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("OrderLineItemId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("OrderLineItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.InvoiceStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PendingPayment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paid"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Canceled"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CountryFlagUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.OrderLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("OrdersStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accepted"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountPercentage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeatured")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductStatusId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Guaranteed to not leave a trace! Perfect for prank dinners.",
                            DiscountPercentage = 0,
                            ImageUrl = "/images/invisible-spaghetti.png",
                            IsFeatured = true,
                            Name = "Invisible Spaghetti",
                            Price = 9.99m,
                            ProductCategoryId = 1,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Never runs out of coffee... because it starts empty!",
                            DiscountPercentage = 5,
                            ImageUrl = "/images/infinite-coffee.png",
                            IsFeatured = false,
                            Name = "Infinite Coffee Mug",
                            Price = 12.50m,
                            ProductCategoryId = 1,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Learn to 'squeak' like a pro in just 10 days!",
                            DiscountPercentage = 0,
                            ImageUrl = "/images/dolphin-book.png",
                            IsFeatured = false,
                            Name = "How to Speak Seal",
                            Price = 19.99m,
                            ProductCategoryId = 2,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Master the fine art of sitting still with expert tips.",
                            DiscountPercentage = 10,
                            ImageUrl = "/images/doing-nothing.png",
                            IsFeatured = true,
                            Name = "The Art of Doing Coding",
                            Price = 14.99m,
                            ProductCategoryId = 2,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Experience the thrill of RPS in stunning 8K resolution!",
                            DiscountPercentage = 50,
                            ImageUrl = "/images/rps-simulator.png",
                            IsFeatured = true,
                            Name = "Ultimate Rock-Paper-Scissors Simulator",
                            Price = 4.99m,
                            ProductCategoryId = 3,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Hide in the most ridiculous places without ever leaving your couch.",
                            DiscountPercentage = 15,
                            ImageUrl = "/images/hide-and-seek.png",
                            IsFeatured = false,
                            Name = "Extreme Hide and Seek VR",
                            Price = 29.99m,
                            ProductCategoryId = 3,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Includes 50 minutes of uninterrupted peace and quiet.",
                            DiscountPercentage = 0,
                            ImageUrl = "/images/silence-album.png",
                            IsFeatured = false,
                            Name = "Greatest Hits of Silence",
                            Price = 5.99m,
                            ProductCategoryId = 4,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Your favorite hits, now featuring a screaming goat.",
                            DiscountPercentage = 20,
                            ImageUrl = "/images/screaming-goat.png",
                            IsFeatured = true,
                            Name = "Screaming Goat Remixes",
                            Price = 11.99m,
                            ProductCategoryId = 4,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Everything you need to pretend you're on vacation, while staying home.",
                            DiscountPercentage = 5,
                            ImageUrl = "/images/staycation-package.png",
                            IsFeatured = true,
                            Name = "Staycation Package",
                            Price = 99.99m,
                            ProductCategoryId = 5,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Plan vacations to destinations that don't exist yet.",
                            DiscountPercentage = 25,
                            ImageUrl = "/images/time-travel-planner.png",
                            IsFeatured = false,
                            Name = "Time Travel Planner K1000",
                            Price = 299.99m,
                            ProductCategoryId = 5,
                            ProductStatusId = 1
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProductCategoryStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryStatusId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Games",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Music",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Holidays",
                            ProductCategoryStatusId = 1
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductCategoryStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategoryStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 255,
                            Name = "Deleted"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ProductStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 255,
                            Name = "Deleted"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Role", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Key");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Key = "admin",
                            Name = "Administrator"
                        },
                        new
                        {
                            Key = "user",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RoleKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleKey");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            FullName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAECJCSH7Y7+DSAD+UKEnb6fjgOROzppnUpop5/kVMcBDjzOVaLz0vts978iw4ooBhhQ==",
                            RoleKey = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@user.com",
                            FullName = "user",
                            PasswordHash = "AQAAAAEAACcQAAAAEH2PV/R1HciXgHqwrYcEp/32IrxaQ44wcbBnM6EHK2FXA5wZRYXN6pddtVKNqTpTxg==",
                            RoleKey = "user"
                        });
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Invoice", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.InvoiceStatus", "InvoiceStatus")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_InvoiceStatus");

                    b.HasOne("InterwayAPI.Domain.Entities.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_Order");

                    b.HasOne("InterwayAPI.Domain.Entities.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_User");

                    b.Navigation("InvoiceStatus");

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.InvoiceLineItem", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.Invoice", "Invoice")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_Invoice");

                    b.HasOne("InterwayAPI.Domain.Entities.OrderLineItem", "OrderLineItem")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("OrderLineItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_OrderLineItem");

                    b.HasOne("InterwayAPI.Domain.Entities.Product", "Product")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_Product");

                    b.Navigation("Invoice");

                    b.Navigation("OrderLineItem");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Order", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Order_OrderStatus");

                    b.HasOne("InterwayAPI.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.OrderLineItem", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.Order", "Order")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_OrderLineItem_Order");

                    b.HasOne("InterwayAPI.Domain.Entities.Product", "Product")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_OrderLineItem_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Product", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProductCategory");

                    b.HasOne("InterwayAPI.Domain.Entities.ProductStatus", "ProductStatus")
                        .WithMany("Products")
                        .HasForeignKey("ProductStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProductStatus");

                    b.Navigation("ProductCategory");

                    b.Navigation("ProductStatus");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.ProductCategoryStatus", "ProductCategoryStatus")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductCategoryStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_ProductCategory_ProductCategoryStatus");

                    b.Navigation("ProductCategoryStatus");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.User", b =>
                {
                    b.HasOne("InterwayAPI.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleKey")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Invoice", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.InvoiceStatus", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Order", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.OrderLineItem", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Product", b =>
                {
                    b.Navigation("InvoiceLineItems");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductCategoryStatus", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.ProductStatus", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("InterwayAPI.Domain.Entities.User", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
