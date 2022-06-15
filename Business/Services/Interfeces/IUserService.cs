using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Jwt;
using Core;
using Entities.Dtos;

namespace Business.Services.Interfeces
{
    public interface IUserService
    {
        Users GetById(int Id);
        Users Login(string UserName, string Password);
        List<Users> GetList();
        List<UsersDto> GetListUserRol();
        UsersDto GetListUserRol(string Username, string Password);
        string Add(Users User);
        string Update(Users User);
        string Delete(Users User);
        object GetById();
        List<OperationClaim> GetClaims(Users user);

    }
}
