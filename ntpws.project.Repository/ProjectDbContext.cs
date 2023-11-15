using Microsoft.EntityFrameworkCore;
using ntpws.project.Model;
using ntpws.project.Repository.Configurations;

namespace ntpws.project.Repository
{
    public class ProjectDbContext: DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
