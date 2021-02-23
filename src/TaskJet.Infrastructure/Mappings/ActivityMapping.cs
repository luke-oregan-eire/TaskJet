using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskJet.Domain.Models;

namespace TaskJet.Infrastructure.Mappings
{
    public class ActivityMapping : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(b => b.Description)
                .IsRequired(false)
                .HasColumnType("varchar(400)");

            builder.Property(b => b.DateCreated)
                .IsRequired();

            builder.Property(b => b.DueDate)
                .IsRequired();

            builder.Property(b => b.CategoryId)
                .IsRequired();

            builder.ToTable("Activities");
        }
    }
}
