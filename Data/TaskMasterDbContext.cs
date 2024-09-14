using Microsoft.EntityFrameworkCore;
using TaskMaster.Models;

namespace TaskMaster.Data
{
    public class TaskMasterDbContext : DbContext
    {
        public TaskMasterDbContext(DbContextOptions<TaskMasterDbContext> options)
         : base(options)
        {
        }
        public DbSet<UserTask> UserTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().HasData(
                InitialDataHelper.SeedData()
            );
        }
    }
}
