using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prestadores_Domain.Entities;
using Prestadores_infrastructure.Configuration;

namespace Prestadores_Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Service> Servicos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                  .ApplyConfiguration(new PrestadorConfiguration())
                  .ApplyConfiguration(new ServicoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
  
    }
}
