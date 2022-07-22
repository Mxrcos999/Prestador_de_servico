using Prestadores_Domain.EntityCore;

namespace Prestadores_Domain.Entities
{
    public class Cidade : Entity
    {
        public string Name { get; set; }
        public string State { get; set; }
        public Cidade(string nome, string estado)
        {
            Name = nome;
            State = estado;
        }
    }
}
