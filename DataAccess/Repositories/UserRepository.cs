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
    public class UserRepository : EntityRepositoryBase<Users, InspeccoContext>, IUserRepository
    {
        public List<UsersDto> GetListUserRol()
        {
            using (var db = new InspeccoContext())
            {
                return db.UserDtoQuery.FromSqlRaw($"EXEC  [dbo].[GetListUserRol] ").ToList();
            }
        }
        public List<OperationClaim> GetClaims(Users user)
        {
            using (var context = new InspeccoContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.Kullanici_ID == user.UserId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
