using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskJet.Domain.Models;

namespace TaskJet.Infrastructure.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.HasMany(c => c.Activities)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId);

            builder.ToTable("Categories");
        }
    }
}
