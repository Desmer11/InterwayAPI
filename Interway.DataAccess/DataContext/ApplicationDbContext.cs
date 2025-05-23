﻿using InterwayAPI.Domain.Entities;
using InterwayAPI.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InterwayAPI.DataAccess.DataContext
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
			ChangeTracker.AutoDetectChangesEnabled = false;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			modelBuilder.SeedProducts()
						.SeedProductCategory()
						.SeedProductCategoryStatus()
						.SeedProductStatus()
						.SeedRoles()
						.SeedUsers()
						.SeedInvoiceStatuses()
						.SeedOrderStatuses();
		}

		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
		public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderLineItem> OrdersLineItems { get; set; }
		public DbSet<OrderStatus> OrdersStatuses { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductStatus> ProductStatuses { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductCategoryStatus> ProductCategoryStatuses { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
