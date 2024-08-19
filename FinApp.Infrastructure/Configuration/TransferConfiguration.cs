using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TransferConfiguration : IEntityTypeConfiguration<Transfer>
{
    public void Configure(EntityTypeBuilder<Transfer> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Amount)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(t => t.TransferDate)
               .IsRequired();

        builder.Property(t => t.Status)
               .IsRequired();

        builder.Property(t => t.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(t => t.SenderAccount)
               .WithMany(a => a.TransfersSent)
               .HasForeignKey(t => t.SenderAccountId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.ReceiverAccount)
               .WithMany(a => a.TransfersReceived)
               .HasForeignKey(t => t.ReceiverAccountId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
