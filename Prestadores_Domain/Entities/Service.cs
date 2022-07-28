using Prestadores_Domain.EntityCore;
using System.Collections.Generic;

namespace Prestadores_Domain.Entities
{
    public class Service : Entity
    {
        public string Name { get; set; }
        public decimal Price{ get; set; }
        public Prestador Provideed { get; set; }
        public Service(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
