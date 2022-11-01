using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository 
    {
        public EmpresaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Empresa> GetAllEmpresas(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Nombre)
            .ToList();

    }
}
