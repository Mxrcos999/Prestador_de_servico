using Prestadores_Domain.EntityCore;

namespace Prestadores_Domain.Entities
{
    public class Service : Entity
    {
        public string Name { get; set; }
        public decimal Price{ get; set; }
        public int ProvidedId { get; set; }
        public Prestador Provided { get; set; }
        public Service(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
