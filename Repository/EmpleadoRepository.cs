using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EmpleadoRepository : RepositoryBase<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
