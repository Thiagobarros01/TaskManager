using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;
namespace TaskManager.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {

       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Tasks> Tasks { get; set; }
    }
}
