using Prestadores_Domain.Entities;
using System.Collections.Generic;

namespace Prestadores_App.Models
{
    public class PrestadorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public IEnumerable<Service> ServiceProvided { get; set; }


    }
}
