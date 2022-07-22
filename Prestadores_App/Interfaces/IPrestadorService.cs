using Prestadores_App.Models;
using Prestadores_Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prestadores_App.Interfaces
{
    public interface IPrestadorService
    {
        Task<IEnumerable<Prestador>> GetAll();
        Task Add(PrestadorViewModel prestador);
        Task<Prestador> Edit(int? id);
        Task<Prestador> Edit(int? id, PrestadorViewModel prestador);

        Task Delete(int? id);


    }
}
