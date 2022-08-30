using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    // Las propiedades se asignarán a las columnas de la base de datos.
    public class Empleado
    {
        [Column("EmpleadoId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nombre is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Nombre is 30 characters.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Edad is a required field.")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Posicion is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Posicion is 20 characters.")]
        public string Posicion { get; set; }
        [ForeignKey(nameof(Empresa))]
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
