using Prestadores_App.Models;
using Prestadores_Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prestadores_App.Interfaces
{
    public interface IServicesService
    {
        Task<IEnumerable<Service>> GetAll();
        Task Add(ServiceViewModel service);
        Task<Service> Edit(int? id);
        Task<Service> Edit(int? id, ServiceViewModel service);

    }
}
