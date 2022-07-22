using Prestadores_App.Interfaces;
using Prestadores_App.Models;
using Prestadores_Domain.Entities;
using Prestadores_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prestadores_App.Services
{
    public class ServicesService : IServicesService
    {
        private readonly IUnitOfWork _uow;
        private readonly IServiceRepository _serviceRepository;
        public ServicesService(IUnitOfWork uow, IServiceRepository serviceRepository)
        {
            _uow = uow;
            _serviceRepository = serviceRepository;
        }
        public async Task Add(ServiceViewModel service)
        {
            try
            {
                var _service = new Service(service.Name, service.Price);
                await _serviceRepository.Add(_service);
                await _uow.Commit();
            }
            catch (Exception)
            {
                await _uow.Rollback();
            }
        }

        public async Task<Service> Edit(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _serviceRepository.Edit(id);
        }

        public async Task<Service> Edit(int? id, ServiceViewModel service)
        {
            if (id != service.Id)
                return null;
 
            var newService = new Service(service.Name, service.Price);
            var _service = await _serviceRepository.Edit(id, newService);

            if (_service == null)
                return null;
            return _service;
        }
    

        public async Task<IEnumerable<Service>> GetAll()
        {
            return await _serviceRepository.GetAll();
        }
    }
}
