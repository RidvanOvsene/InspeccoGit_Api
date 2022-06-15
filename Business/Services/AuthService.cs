using Business.Services.Interfeces;
using Core.Jwt;
using Entities;
using Entities.Dtos;

namespace Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly ITokenHelper _tokenHelper;

        public AuthService(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public UsersDto Login(UsersDto userForLoginDto)
        {
            var userToCheck = _userService.GetListUserRol(userForLoginDto.UserName, userForLoginDto.Password);

            return userToCheck;
        }

        public AccessToken CreateAccessToken(Users user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
        }
    }
}
