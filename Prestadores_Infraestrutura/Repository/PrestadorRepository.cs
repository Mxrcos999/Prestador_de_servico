using Microsoft.EntityFrameworkCore;
using Prestadores_Domain.Entities;
using Prestadores_Domain.Interfaces;
using Prestadores_Infrastructure.Context;
using System.Linq;
using System.Threading.Tasks;

namespace Prestadores_infrastructure.Repository
{
    public class PrestadorRepository : IPrestadorRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Prestador> _DbSet;

        public PrestadorRepository(ApplicationDbContext context)
        {
            _context = context;
            _DbSet = _context.Set<Prestador>();
        }
        public async Task Add(Prestador prestador)
        {
            await _DbSet.AddAsync(prestador);
        }

        public async Task<Prestador> Edit(int? id)
        {
            return _context.Prestadores.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public async Task<Prestador> Edit(int? id, Prestador prestador)
        {
            try
            {
                 _context.Update(prestador);
                 return prestador;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrestadorExists(prestador.Id))
                {
                    return null;
                }
                else { throw; }
            }
        }
        private bool PrestadorExists(int id)
        {
            return _context.Prestadores.AsNoTracking().Any(e => e.Id == id);
        }
        public async Task<IQueryable<Prestador>> GetAll()
        {
            try
            {
                var prestadores = _context.Prestadores.AsNoTracking();
                return prestadores;
            }
            catch (System.Exception)
            {

                throw;
            }
          
        }
    }
}
