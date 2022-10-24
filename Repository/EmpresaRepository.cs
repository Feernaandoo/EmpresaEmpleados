using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository 
    {
        public EmpresaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
