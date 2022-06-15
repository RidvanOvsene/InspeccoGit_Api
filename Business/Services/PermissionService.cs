using Business.Services.Interfeces;
using DataAccess.Repositories.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PermissionService : IPermissionService
    {
        private IPermissionRepository _permissionRepository;
        public PermissionService(IPermissionRepository PermissionRepository)
        {
            _permissionRepository = PermissionRepository;
        }

        public Permission GetById(int Id)
        {
            return _permissionRepository.Get(a => a.PermissionId == Id);
        }

        public List<Permission> GetList()
        {
            return _permissionRepository.GetList().ToList();
        }
        public string Add(Permission permission)
        {
            _permissionRepository.Add(permission);
            return "Ok";
        }
        public string Update(Permission permission)
        {
            _permissionRepository.Update(permission);
            return "Ok";
        }
        public string Delete(Permission permission)
        {
            _permissionRepository.Delete(permission);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}