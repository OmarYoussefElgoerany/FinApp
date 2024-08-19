using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Action)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(a => a.Details)
               .HasMaxLength(500);

        builder.Property(a => a.Timestamp)
               .IsRequired();

        // Relationships
        builder.HasOne(a => a.User)
               .WithMany(u => u.AuditLogs)
               .HasForeignKey(a => a.UserId);
    }
}
