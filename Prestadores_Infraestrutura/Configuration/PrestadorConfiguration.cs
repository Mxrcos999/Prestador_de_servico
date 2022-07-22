using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prestadores_Domain.Entities;
using Prestadores_Domain.ValueObject;

namespace Prestadores_infrastructure.Configuration
{
    public class PrestadorConfiguration : IEntityTypeConfiguration<Prestador>
    {
        public void Configure(EntityTypeBuilder<Prestador> builder)
        {
            var EmailConverter = new ValueConverter<Email, string>(v => v.ToString(), v => Email.Parse(v));


            builder
                 .Property(company => company.Email)
                 .HasConversion(EmailConverter);


            builder
                .Property(p => p.DateHourRegister)
                .HasDefaultValueSql("Now()");

          

        }
    }
}
