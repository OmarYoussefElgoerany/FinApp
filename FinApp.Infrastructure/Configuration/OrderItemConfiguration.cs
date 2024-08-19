using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.ProductName)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(oi => oi.Quantity)
               .IsRequired();

        builder.Property(oi => oi.Price)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(oi => oi.TotalPrice)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(oi => oi.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(oi => oi.Order)
               .WithMany(o => o.OrderItems)
               .HasForeignKey(oi => oi.OrderId);
    }
}
