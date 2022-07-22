using Prestadores_App.Interfaces;
using Prestadores_App.Models;
using Prestadores_Domain.Entities;
using Prestadores_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prestadores_App.Services
{
    public class PrestadorService : IPrestadorService
    {
        private readonly IPrestadorRepository _prestadorRepository;
        private readonly IUnitOfWork _uow;

        public PrestadorService(IPrestadorRepository prestadorRepository, IUnitOfWork uow)
        {
            _prestadorRepository = prestadorRepository;
            _uow = uow;
        }

        public async Task Add(PrestadorViewModel prestador)
        {

            var _prestador = new Prestador(prestador.Name, prestador.PhoneNumber, prestador.Email, prestador.City);
            try
            {
                await _prestadorRepository.Add(_prestador);
                await _uow.Commit();
            }
            catch (Exception)
            {
               await _uow.Rollback();     
            }
               
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }
        public async Task<Prestador> Edit(int? id, PrestadorViewModel prestador)
        {
            if (id == null)
            {
                return null;
            }
            var Novoprestador = new Prestador(prestador.Name, prestador.PhoneNumber, prestador.Email, prestador.City);
            try
            {
                var _prestaodor = await _prestadorRepository.Edit(id, Novoprestador);
                await _uow.Commit();
                return _prestaodor;

            }
            catch (Exception)
            {
                await _uow.Rollback();
                throw;            }
        }

        public async Task<Prestador> Edit(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return await _prestadorRepository.Edit(id);
        }

        public async Task<IEnumerable<Prestador>> GetAll()
        {
             return await _prestadorRepository.GetAll();
        }

    
    }
}
