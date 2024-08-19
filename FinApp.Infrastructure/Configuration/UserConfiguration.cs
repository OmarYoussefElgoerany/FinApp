using FinApp.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.FullName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            builder.Property(u => u.PhoneNumber)
                   .HasMaxLength(15);

            builder.Property(u => u.Address)
                   .HasMaxLength(300);

            builder.Property(u => u.DateOfBirth)
                   .IsRequired();

            builder.Property(u => u.ProfilePictureURL)
                   .HasMaxLength(500);

            builder.Property(u => u.CreatedAt)
                   .IsRequired();

            builder.Property(u => u.UpdatedAt)
                   .IsRequired();

            builder.Property(u => u.LastLoginAt);

            builder.Property(u => u.IsVerified)
                   .IsRequired();

            // Relationships
            builder.HasMany(u => u.Accounts)
                   .WithOne(a => a.User)
                   .HasForeignKey(a => a.UserId);

            builder.HasMany(u => u.Notifications)
                   .WithOne(n => n.User)
                   .HasForeignKey(n => n.UserId);

            builder.HasMany(u => u.Orders)
                   .WithOne(o => o.User)
                   .HasForeignKey(o => o.UserId);

            builder.HasMany(u => u.Payments)
                   .WithOne(p => p.User)
                   .HasForeignKey(p => p.UserId);

            builder.HasMany(u => u.Budgets)
                   .WithOne(b => b.User)
                   .HasForeignKey(b => b.UserId);

            builder.HasMany(u => u.AuditLogs)
                   .WithOne(a => a.User)
                   .HasForeignKey(a => a.UserId);
        }
    }
}
