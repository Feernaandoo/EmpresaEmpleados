using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contracts
{
    public interface IEmpresaRepository
    {
        IEnumerable<Empresa> GetAllEmpresas(bool trackChanges);
    }
}
