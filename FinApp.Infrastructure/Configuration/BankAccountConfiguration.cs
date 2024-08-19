using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        builder.HasKey(ba => ba.Id);

        builder.Property(ba => ba.AccountHolderName)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(ba => ba.BankName)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(ba => ba.AccountNumber)
               .IsRequired()
               .HasMaxLength(20);

        builder.Property(ba => ba.RoutingNumber)
               .IsRequired()
               .HasMaxLength(9);

        builder.Property(ba => ba.AccountType)
               .IsRequired();

        builder.Property(ba => ba.CreatedAt)
               .IsRequired();

        builder.Property(ba => ba.UpdatedAt);

        // Relationships
        builder.HasOne(ba => ba.User)
               .WithMany(u => u.BankAccounts)
               .HasForeignKey(ba => ba.UserId);
    }
}
