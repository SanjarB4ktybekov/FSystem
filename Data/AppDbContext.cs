using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FSystem.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Player> Players{get;set;}
        public DbSet<Coach> Coaches{get;set;}
        public DbSet<Consumption> Consumptions{get;set;}
        public DbSet<Income> Incomes{get;set;}
        public DbSet<Schedule> Schedules{get;set;}
        public DbSet<Balance> Balance{get;set;}
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}