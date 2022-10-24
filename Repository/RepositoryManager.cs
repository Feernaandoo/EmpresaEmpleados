using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IEmpresaRepository _empresaRepository;
        private IEmpleadoRepository _empleadoRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IEmpresaRepository Empresa
        {
            get 
            {
                if (_empresaRepository == null)
                    _empresaRepository = new EmpresaRepository(_repositoryContext);

                return _empresaRepository; 
            }
        }

        public IEmpleadoRepository Empleado 
        { 
            get 
            {
                if( _empleadoRepository == null)
                    _empleadoRepository = new EmpleadoRepository(_repositoryContext);

                return _empleadoRepository; 
            } 
        }

        IEmpleadoRepository IRepositoryManager.Empresa => throw new NotImplementedException();

        public void Save() => _repositoryContext.SaveChanges();
    }
}
