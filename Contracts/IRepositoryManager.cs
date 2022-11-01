using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IEmpresaRepository Empresa { get; }
        IEmpleadoRepository Empleado { get; }
        void Save();
    }
}
