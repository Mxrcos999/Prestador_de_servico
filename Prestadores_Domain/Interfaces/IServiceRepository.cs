using Prestadores_Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Prestadores_Domain.Interfaces
{
    public interface IServiceRepository
    {
        Task Add(Service service);
        Task<IQueryable<Service>> GetAll();
        Task<Service> Edit(int? id, Service service);
        Task<Service> Edit(int? id);
    }
}
