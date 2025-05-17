using Microsoft.EntityFrameworkCore;
using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Devotee> Devotees { get; set; }
        public DbSet<DevoteeContact> DevoteeContacts { get; set; }
    }
}
