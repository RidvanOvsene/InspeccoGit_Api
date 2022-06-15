using Core;
using DataAccess.Context;
using DataAccess.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RolPermissionRepository : EntityRepositoryBase<RolPermission, InspeccoContext>, IRolPermissionRepository
    {
        public List<RolPermissionDto> GetListRolPermission()
        {
            using (var db = new InspeccoContext())
            {
                return db.RolPermissionDtoQuery.FromSqlRaw($"EXEC  [dbo].[GetListRolPermission] ").ToList();
            }
        }
    }
}
