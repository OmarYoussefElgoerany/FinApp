using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Amount)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(t => t.TransactionType)
               .IsRequired();

        builder.Property(t => t.Category)
               .IsRequired();

        builder.Property(t => t.Description)
               .HasMaxLength(500);

        builder.Property(t => t.TransactionDate)
               .IsRequired();

        builder.Property(t => t.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(t => t.Account)
               .WithMany(a => a.Transactions)
               .HasForeignKey(t => t.AccountID);
    }
}
