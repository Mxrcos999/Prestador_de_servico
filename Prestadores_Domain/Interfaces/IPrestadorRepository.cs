using Prestadores_Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Prestadores_Domain.Interfaces
{
    public interface IPrestadorRepository
    {
        Task Add(Prestador prestador);
        Task<IQueryable<Prestador>> GetAll();
        Task<Prestador> Edit(int? id, Prestador prestador);
        Task<Prestador> Edit(int? id);


    }
}
