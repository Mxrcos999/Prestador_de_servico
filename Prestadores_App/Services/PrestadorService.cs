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

        public PrestadorService(IPrestadorRepository prestadorRepository)
        {
            _prestadorRepository = prestadorRepository;
        }

        public async Task Add(PrestadorViewModel prestador)
        {

            var _prestador = new Prestador(prestador.Name, prestador.PhoneNumber, prestador.Email, prestador.City); 
            await _prestadorRepository.Add(_prestador);
           
               
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
            var _prestaodor = await _prestadorRepository.Edit(id, Novoprestador);
            return _prestaodor;
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
