using System;
using System.Threading.Tasks;

namespace Prestadores_Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
        Task Rollback();
    }
}
