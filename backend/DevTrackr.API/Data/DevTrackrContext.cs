using Microsoft.EntityFrameworkCore;
using DevTrackr.API.Models;


namespace DevTrackr.API.Data
{
    public class DevTrackrContext : DbContext
    {
        public DevTrackrContext(DbContextOptions<DevTrackrContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }
        public DbSet<ProjectGoal> Goals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(DevTrackrContext).Assembly);
        }
    }
}