using Prestadores_Domain.EntityCore;
using System.Collections.Generic;

namespace Prestadores_Domain.Entities
{
    public class Cidade : Entity
    {
        public string Name { get; set; }
        public string State { get; set; }
      //  public List<Prestador> PrestadorId { get; set; }
        public Cidade(string nome, string estado)
        {
            Name = nome;
            State = estado;
        }
    }
}
