using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers").HasKey(b => b.Id);
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.Property(b => b.Address).HasColumnName("Address").IsRequired();
        builder.Property(b => b.Email).HasColumnName("Email").IsRequired();
        builder.Property(b => b.Phone).HasColumnName("Phone").IsRequired();

        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpadetedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: b => b.Name, name: "UK_Customers_Name").IsUnique();


        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

    }
}
