using Microsoft.EntityFrameworkCore;
using Prestadores_Domain.Entities;
using Prestadores_Domain.Interfaces;
using Prestadores_Infrastructure.Context;
using System.Linq;
using System.Threading.Tasks;

namespace Prestadores_infrastructure.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Service> _DbSet;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
            _DbSet = _context.Set<Service>();
        }
        public async Task Add(Service service)
        {
            await _DbSet.AddAsync(service);
        }

        public async Task<Service> Edit(int? id, Service service)
        {
            try
            {
                _context.Update(service);
                return service;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceExists(service.Id))
                {
                    return null;
                }
                else { throw; }
            }
        }
        private bool ServiceExists(int id)
        {
            return _context.Servicos.Any(e => e.Id == id);
        }
        public async Task<Service> Edit(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return _context.Servicos.AsNoTracking().FirstOrDefault(e => e.Id == id);

        }

        public async Task<IQueryable<Service>> GetAll()
        {
            var query = _context.Servicos.AsNoTracking();
            return query;
        }
    }
}
