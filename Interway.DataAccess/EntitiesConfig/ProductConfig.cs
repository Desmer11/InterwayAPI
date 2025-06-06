﻿using InterwayAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterwayAPI.DataAccess.EntitiesConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasPrecision(10, 2);
            builder.Property(x => x.ProductStatusId).HasDefaultValue(1);
            builder.Property(x => x.IsFeatured).HasDefaultValue(false);
            builder.Property(x => x.DiscountPercentage).HasDefaultValue(0);

            builder.HasOne(x => x.ProductCategory)
               .WithMany(x => x.Products)
               .HasForeignKey(x => x.ProductCategoryId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Product_ProductCategory");

            builder.HasOne(x => x.ProductStatus)
               .WithMany(x => x.Products)
               .HasForeignKey(x => x.ProductStatusId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Product_ProductStatus");
        }
    }
}
