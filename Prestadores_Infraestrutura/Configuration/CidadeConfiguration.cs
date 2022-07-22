using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestadores_Domain.Entities;

namespace Prestadores_infrastructure.Configuration
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            //builder.HasMany(cidade => cidade.PrestadorId)
            //  .WithOne(prestador => prestador.CityId)
            //  .HasForeignKey(prestador => prestador.CityId)
            //  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
