using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class EmpresaDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string DireccionCompleta { get; set; }
    }
}
