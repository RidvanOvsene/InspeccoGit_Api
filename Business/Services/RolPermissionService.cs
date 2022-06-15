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
    public class RolPermissionService : IRolPermissionService
    {
        private IRolPermissionRepository _rolPermissionRepository;
        public RolPermissionService(IRolPermissionRepository RolPermissionRepository)
        {
            _rolPermissionRepository = RolPermissionRepository;
        }

        public RolPermission GetById(int Id)
        {
            return _rolPermissionRepository.Get(a => a.RolPermissionId == Id);
        }
        public List<RolPermissionDto> GetByRoleId(int RoleId)
        {
            return new List<RolPermissionDto>(_rolPermissionRepository.GetListRolPermission().ToList().Where(a => a.RolId == RoleId));
        }
        public List<RolPermission> GetList()
        {
            return _rolPermissionRepository.GetList().ToList();
        }
        public string Add(RolPermission rolPermission)
        {
            _rolPermissionRepository.Add(rolPermission);
            return "Ok";
        }
        public List<RolPermissionDto> GetListRolPermission()
        {
            return new List<RolPermissionDto>(_rolPermissionRepository.GetListRolPermission().ToList());
        }
        public string Update(RolPermission rolPermission)
        {
            _rolPermissionRepository.Update(rolPermission);
            return "Ok";
        }
        public string Delete(RolPermission rolPermission)
        {
            _rolPermissionRepository.Delete(rolPermission);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}