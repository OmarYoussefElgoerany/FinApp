using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.TotalAmount)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(o => o.OrderDate)
               .IsRequired();

        builder.Property(o => o.Status)
               .IsRequired();

        builder.Property(o => o.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(o => o.User)
               .WithMany(u => u.Orders)
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.Restrict); // Ensure no cascade delete conflicts

        builder.HasMany(o => o.OrderItems)
               .WithOne(oi => oi.Order)
               .HasForeignKey(oi => oi.OrderId);
        builder.HasOne(o => o.Payment)
               .WithOne(p => p.Order)
               .HasForeignKey<Order>(o => o.PaymentID)
               .OnDelete(DeleteBehavior.Restrict); // Adjusted to restrict cascade
    }
}
