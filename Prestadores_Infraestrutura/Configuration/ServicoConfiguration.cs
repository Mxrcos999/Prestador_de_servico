﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestadores_Domain.Entities;

namespace Prestadores_infrastructure.Configuration
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                 .HasOne(p => p.Provideed)
                 .WithMany(s => s.ServiceProvided)
                 .OnDelete(DeleteBehavior.Cascade);
                
                
        }
    }
}
