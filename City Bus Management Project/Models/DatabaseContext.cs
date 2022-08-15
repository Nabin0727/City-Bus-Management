using Microsoft.EntityFrameworkCore;

namespace City_Bus_Management_Project.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
    
        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Signup> Signups { get; set; }

        public DbSet<Add> Adds { get; set; }

    }
}
