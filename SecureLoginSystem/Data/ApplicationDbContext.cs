using Microsoft.EntityFrameworkCore;
using SecureLoginSystem.Models; // תשני לפי הפרויקט שלך

namespace SecureLoginSystem.Data
{
    public class ApplicationDbContext : DbContext   
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}