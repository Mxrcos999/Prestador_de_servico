using System;

namespace Prestadores_Domain.EntityCore
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime DateHourRegister { get; set; }
        public DateTime? DateHourChange { get; set; }
    }
}
