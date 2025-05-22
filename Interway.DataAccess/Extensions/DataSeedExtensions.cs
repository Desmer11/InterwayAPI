using InterwayAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterwayAPI.DataAccess.Extensions
{
    public static class DataSeedExtensions
    {
        public static ModelBuilder SeedProductCategoryStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategoryStatus>().HasData(
                new ProductCategoryStatus { Id = 1, Name = "Active" },
                new ProductCategoryStatus { Id = 255, Name = "Deleted" }
            );
            return modelBuilder;
        }

        public static ModelBuilder SeedProductStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductStatus>().HasData(
             new ProductStatus { Id = 1, Name = "Active" },
             new ProductStatus { Id = 255, Name = "Deleted" }
            );
            return modelBuilder;
        }

        public static ModelBuilder SeedProductCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name = "Food", ProductCategoryStatusId = 1 },
                new ProductCategory { Id = 2, Name = "Books", ProductCategoryStatusId = 1 },
                new ProductCategory { Id = 3, Name = "Games", ProductCategoryStatusId = 1 },
                new ProductCategory { Id = 4, Name = "Music", ProductCategoryStatusId = 1 },
                new ProductCategory { Id = 5, Name = "Holidays", ProductCategoryStatusId = 1 }
            );
            return modelBuilder;
        }

        public static ModelBuilder SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

		// Food
		new Product
		{
			Id = 1,
			Name = "Invisible Spaghetti",
			Description = "Guaranteed to not leave a trace! Perfect for prank dinners.",
			ImageUrl = "/images/invisible-spaghetti.png",
			ProductCategoryId = 1, // Food
			ProductStatusId = 1, // Active
			Price = 9.99m,
			IsFeatured = true,
			DiscountPercentage = 0
		},
		new Product
		{
			Id = 2,
			Name = "Infinite Coffee Mug",
			Description = "Never runs out of coffee... because it starts empty!",
			ImageUrl = "/images/infinite-coffee.png",
			ProductCategoryId = 1, // Food
			ProductStatusId = 1, // Active
			Price = 12.50m,
			IsFeatured = false,
			DiscountPercentage = 5
		},

		// Books
		new Product
		{
			Id = 3,
			Name = "How to Speak Seal",
			Description = "Learn to 'squeak' like a pro in just 10 days!",
			ImageUrl = "/images/dolphin-book.png",
			ProductCategoryId = 2, // Books
			ProductStatusId = 1, // Active
			Price = 19.99m,
			IsFeatured = false,
			DiscountPercentage = 0
		},
		new Product
		{
			Id = 4,
			Name = "The Art of Doing Coding",
			Description = "Master the fine art of sitting still with expert tips.",
			ImageUrl = "/images/doing-nothing.png",
			ProductCategoryId = 2, // Books
			ProductStatusId = 1, // Active
			Price = 14.99m,
			IsFeatured = true,
			DiscountPercentage = 10
		},

		// Games
		new Product
		{
			Id = 5,
			Name = "Ultimate Rock-Paper-Scissors Simulator",
			Description = "Experience the thrill of RPS in stunning 8K resolution!",
			ImageUrl = "/images/rps-simulator.png",
			ProductCategoryId = 3, // Games
			ProductStatusId = 1, // Active
			Price = 4.99m,
			IsFeatured = true,
			DiscountPercentage = 50
		},
		new Product
		{
			Id = 6,
			Name = "Extreme Hide and Seek VR",
			Description = "Hide in the most ridiculous places without ever leaving your couch.",
			ImageUrl = "/images/hide-and-seek.png",
			ProductCategoryId = 3, // Games
			ProductStatusId = 1, // Active
			Price = 29.99m,
			IsFeatured = false,
			DiscountPercentage = 15
		},

		// Music
		new Product
		{
			Id = 7,
			Name = "Greatest Hits of Silence",
			Description = "Includes 50 minutes of uninterrupted peace and quiet.",
			ImageUrl = "/images/silence-album.png",
			ProductCategoryId = 4, // Music
			ProductStatusId = 1, // Active
			Price = 5.99m,
			IsFeatured = false,
			DiscountPercentage = 0
		},
		new Product
		{
			Id = 8,
			Name = "Screaming Goat Remixes",
			Description = "Your favorite hits, now featuring a screaming goat.",
			ImageUrl = "/images/screaming-goat.png",
			ProductCategoryId = 4, // Music
			ProductStatusId = 1, // Active
			Price = 11.99m,
			IsFeatured = true,
			DiscountPercentage = 20
		},

		// Holidays
		new Product
		{
			Id = 9,
			Name = "Staycation Package",
			Description = "Everything you need to pretend you're on vacation, while staying home.",
			ImageUrl = "/images/staycation-package.png",
			ProductCategoryId = 5, // Holidays
			ProductStatusId = 1, // Active
			Price = 99.99m,
			IsFeatured = true,
			DiscountPercentage = 5
		},
		new Product
		{
			Id = 10,
			Name = "Time Travel Planner K1000",
			Description = "Plan vacations to destinations that don't exist yet.",
			ImageUrl = "/images/time-travel-planner.png",
			ProductCategoryId = 5, // Holidays
			ProductStatusId = 1, // Active
			Price = 299.99m,
			IsFeatured = false,
			DiscountPercentage = 25
		}
			);

            return modelBuilder;
        }

        #region Users/Roles
        public static ModelBuilder SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Key = "admin", Name = "Administrator" },
                new Role { Key = "user", Name = "User" }
            );
            return modelBuilder;
        }

        public static ModelBuilder SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FullName = "Admin", RoleKey = "admin", Email = "admin@admin.com", PasswordHash = "AQAAAAEAACcQAAAAECJCSH7Y7+DSAD+UKEnb6fjgOROzppnUpop5/kVMcBDjzOVaLz0vts978iw4ooBhhQ==" }, // Admin123!
                new User { Id = 2, FullName = "user", RoleKey = "user", Email = "user@user.com", PasswordHash = "AQAAAAEAACcQAAAAEH2PV/R1HciXgHqwrYcEp/32IrxaQ44wcbBnM6EHK2FXA5wZRYXN6pddtVKNqTpTxg==" } // User123!
            );
            return modelBuilder;
        }
        #endregion

        public static ModelBuilder SeedOrderStatuses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, Name = "Pending" },
                new OrderStatus { Id = 2, Name = "Accepted" },
                new OrderStatus { Id = 3, Name = "Rejected" }
            );
            return modelBuilder;
        }

        public static ModelBuilder SeedInvoiceStatuses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceStatus>().HasData(
                new InvoiceStatus { Id = 1, Name = "PendingPayment" },
                new InvoiceStatus { Id = 2, Name = "Paid" },
                new InvoiceStatus { Id = 3, Name = "Canceled" }
            );
            return modelBuilder;
        }
    }
}
