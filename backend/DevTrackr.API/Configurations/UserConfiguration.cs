using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DevTrackr.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevTrackr.API.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);

            builder.Property(x => x.UserName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(x => x.UserName)
                   .IsUnique();

            builder.Property(x => x.UserEmail);

            builder.Property(x => x.PasswordHash)
                   .IsRequired();

            // Configure one-to-many relationship with Tasks
            builder.HasMany(x => x.Tasks)
                   .WithOne(t => t.User)
                   .HasForeignKey(t => t.UserId);

            // Configure one-to-many relationship with ProjectGoals
            builder.HasMany(x => x.Goals)
                   .WithOne(g => g.User)
                   .HasForeignKey(g => g.UserId);
        }
    }
}