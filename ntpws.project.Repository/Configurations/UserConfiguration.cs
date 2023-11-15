using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ntpws.project.Model;

namespace ntpws.project.Repository.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(x => x.Username);

            builder.Property(p => p.Username)
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(p => p.FirstName)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.LastName)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.Email)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.Password)
               .HasMaxLength(10)
               .IsRequired();

            builder.Property(p => p.DateOfBirth)
               .HasMaxLength(255)
               .IsRequired();
        }
    }
}
