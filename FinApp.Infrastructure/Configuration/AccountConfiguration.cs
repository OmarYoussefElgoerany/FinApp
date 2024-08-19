using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.AccountNumber)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(a => a.AccountType)
               .IsRequired();

        builder.Property(a => a.Balance)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(a => a.Currency)
               .IsRequired()
               .HasMaxLength(3);

        builder.Property(a => a.CreatedAt)
               .IsRequired();

        builder.Property(a => a.UpdatedAt);

        // Relationships
        builder.HasOne(a => a.User)
               .WithMany(u => u.Accounts)
               .HasForeignKey(a => a.UserId);

        builder.HasMany(a => a.Transactions)
               .WithOne(t => t.Account)
               .HasForeignKey(t => t.AccountID);

        builder.HasMany(a => a.TransfersSent)
               .WithOne(t => t.SenderAccount)
               .HasForeignKey(t => t.SenderAccountId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.TransfersReceived)
               .WithOne(t => t.ReceiverAccount)
               .HasForeignKey(t => t.ReceiverAccountId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
