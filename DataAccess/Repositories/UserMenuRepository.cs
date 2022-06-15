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
    public class UserMenuRepository : EntityRepositoryBase<UserMenu, InspeccoContext>, IUserMenuRepository
    {
        public List<UserMenuDto> GetListUserMenu()
        {
            using (var db = new InspeccoContext())

            {
                return db.UserMenuDtoQuery.FromSqlRaw($"EXEC  [dbo].[GetListUserMenu] ").ToList();
            }
        }
    }
}
