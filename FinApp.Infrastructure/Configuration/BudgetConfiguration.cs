using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Amount)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.Property(b => b.StartDate)
               .IsRequired();

        builder.Property(b => b.EndDate)
               .IsRequired();

        builder.Property(b => b.Category)
               .HasMaxLength(50);

        builder.Property(b => b.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(b => b.User)
               .WithMany(u => u.Budgets)
               .HasForeignKey(b => b.UserId);
    }
}
