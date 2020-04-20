using Microsoft.EntityFrameworkCore;
using RabbitIntegration.Integrator.Domain.Models;

namespace RabbitIntegration.Integrator.Data.Context
{
    public class IntegratorDbContext : DbContext
    {
        public IntegratorDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<OrderTraking> OrdersTraking { get; set; }
    }
}
