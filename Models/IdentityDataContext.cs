using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityExample.Models
{
    public class IdentityDataContext : DbContext
    {
        public DbSet<IdentityUser> Users { get; set;}

        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
