using EF_MVC_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_MVC_Demo.Data
{
    public class DemoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Greatest", 
                LastName= "Ever", DateOfBirth = new DateTime()});
        }
    }
}
