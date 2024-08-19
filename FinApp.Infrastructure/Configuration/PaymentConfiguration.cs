using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Amount)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(p => p.PaymentMethod)
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(p => p.PaymentDate)
               .IsRequired();

        builder.Property(p => p.Status)
            .HasMaxLength(20)
               .IsRequired();

        builder.Property(p => p.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(p => p.User)
               .WithMany(u => u.Payments)
               .HasForeignKey(p => p.UserId)
               .OnDelete(DeleteBehavior.NoAction); // Adjusted to restrict cascade

        
    }
}

