using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfeces
{
    public interface IPermissionService
    {
        Permission GetById(int Id);
        List<Permission> GetList();
        string Add(Permission permission);
        string Update(Permission permission);
        string Delete(Permission permission);
        object GetById();
    }
}
