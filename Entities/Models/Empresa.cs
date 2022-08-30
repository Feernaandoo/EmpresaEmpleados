using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    // Las propiedades se asignarán a las columnas de la base de datos.
    public class Empresa
    {
        [Column("EmpresaId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nombre de empresa is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Nombre is 60 characters.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Dirección de empresa is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Direccion is 60 characters")]
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
