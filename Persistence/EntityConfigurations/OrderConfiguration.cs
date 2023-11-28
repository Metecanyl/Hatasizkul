using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Persistence.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders").HasKey(b => b.Id);
        builder.Property(b => b.DeliveryAddress).HasColumnName("DeliveryAddress").IsRequired();
        builder.Property(b => b.Items).HasColumnName("Items").IsRequired();
        builder.Property(b => b.TotalAmount).HasColumnName("TotalAmount").IsRequired();
        builder.Property(b => b.Status).HasColumnName("Status").IsRequired();


        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpadetedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        //builder
        // .HasOne(e => e.Customer)
        //  .WithMany(e => e.Orders);
        //builder
        // .HasMany(e => e.Products)
        //  .WithMany(e => e.Orders);



        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

    }
}
