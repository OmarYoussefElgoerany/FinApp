using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.HasKey(n => n.Id);

        builder.Property(n => n.Message)
               .IsRequired()
               .HasMaxLength(500);

        builder.Property(n => n.IsRead)
               .IsRequired();
        builder.Property(n => n.Type)
            .HasMaxLength(50)
              .IsRequired();

        builder.Property(n => n.CreatedAt)
               .IsRequired();

        // Relationships
        builder.HasOne(n => n.User)
               .WithMany(u => u.Notifications)
               .HasForeignKey(n => n.UserId);
    }
}
