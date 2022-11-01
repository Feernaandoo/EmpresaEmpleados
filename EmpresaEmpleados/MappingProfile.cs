using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmpresaEmpleados
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Empresa, EmpresaDto>()
                    .ForMember(c => c.DireccionCompleta,
                        opt => opt.MapFrom(x => string.Join(' ', x.Direccion, x.Pais)));
        }
    }
}
