using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Entities.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        // Llenado de la tabla Empresas con algunos datos iniciales.
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasData
            (
                new Empresa
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Nombre = "Empresa de Seguros S.R.L.",
                    Direccion = "Guaymallen 336, San Vicente",
                    Pais = "Argentina"
                },
                new Empresa
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Nombre = "Soluciones Administrativas S.A.",
                    Direccion = "Lope de Vega 438, Rafaela",
                    Pais = "Argentina"
                }
            );

        }

    }
    
}
