using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        // Llenado de la tabla Empleados con algunos datos iniciales.
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData
            (
            new Empleado
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Nombre = "Samuel Ferrari",
                Edad = 26,
                Posicion = "Desarrollador",
                EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Empleado
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Nombre = "Laura Lopez",
                Edad = 30,
                Posicion = "Desarrollador",
                EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Empleado
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Nombre = "Walter Perez",
                Edad = 35,
                Posicion = "Administrador",
                EmpresaId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
            }
            );
        }
    }
}
