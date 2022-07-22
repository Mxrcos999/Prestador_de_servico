using Prestadores_Domain.EntityCore;
using Prestadores_Domain.ValueObject;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prestadores_Domain.Entities
{
    public class Prestador : Entity
    {
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo email é obrigatório.")]

        public Email Email { get; set; }
        [Required(ErrorMessage = "O campo numero de telefone é obrigatório.")]

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public int ServiceProvidedId { get; set; }

        public IEnumerable<Service> ServiceProvided { get; set; }
        public Prestador(string name, string phoneNumber, Email email, string city)
        {

            if (!email.IsValid) throw new ValidationException("Email inválido");
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            
        //    this.DateHourRegister = DateTime.Now;
        }
        protected Prestador()
        {

        }
    }
}
