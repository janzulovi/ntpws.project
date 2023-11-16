using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ntpws.project.Model;

namespace ntpws.project.Repository.Configurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.ToTable(nameof(Note));
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.CreatedBy)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.CreatedOn)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.NoteType)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.Status)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.DueDate)
               .HasMaxLength(255)
               .IsRequired();
        }
    }
}
