using Core.Jwt;
using Entities;
using Entities.Dtos;

namespace Business.Services.Interfeces
{
    public interface IAuthService
    {
        UsersDto Login(UsersDto userForLoginDto);
        AccessToken CreateAccessToken(Users user);
    }
}
