using A4WebApi.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace A4WebApi.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
    }
}
