using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfeces
{
    public interface IRolPermissionService
    {
        RolPermission GetById(int Id);
        List<RolPermission> GetList();
        List<RolPermissionDto> GetByRoleId(int RoleId);
        List<RolPermissionDto>GetListRolPermission();
        string Add(RolPermission rolPermissionService);
        string Update(RolPermission rolPermissionService);
        string Delete(RolPermission rolPermissionService);
        object GetById();
    }
}
