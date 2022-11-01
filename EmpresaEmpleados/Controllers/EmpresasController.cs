using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace EmpresaEmpleados.Controllers
{
    [Route("api/empresas")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public EmpresasController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetEmpresas()
        {
            try
            {
                var empresas = _repository.Empresa.GetAllEmpresas(trackChanges: false);

                var empresasDto = empresas.Select(c => new EmpresaDto
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    DireccionCompleta = string.Join(' ', c.Direccion, c.Pais)
                }).ToList();
                return Ok(empresasDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetEmpresas)}action { ex}");
            return StatusCode(500, "Internal server error");
            }
        }
    }
}