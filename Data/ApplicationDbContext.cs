using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CapstoneDemo1.Models;
namespace CapstoneDemo1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}