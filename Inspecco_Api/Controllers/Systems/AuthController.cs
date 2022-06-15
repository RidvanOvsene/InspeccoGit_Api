
using Business.Services.Interfeces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Results;
using Entities;
using Entities.Dtos;
using System;

namespace Inspecco_Api.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService,
                              ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }
        [HttpGet("login")]
        public ActionResult Login(string UserName, string Password)
        {
            LoginDto loginDto = new LoginDto();
            UsersDto userForLoginDto = new UsersDto();
            userForLoginDto.Password = Password;
            userForLoginDto.UserName = UserName;
            _logger.LogInformation(userForLoginDto.UserName + " Giriş yaptı");
            var userToLogin = _authService.Login(userForLoginDto);
            var Users = new Users();
            Users.UserId = userToLogin.UserId;
            var result = _authService.CreateAccessToken(Users);
            loginDto.UserName = userToLogin.UserName;
            loginDto.NameSurname = userToLogin.NameSurname;
            loginDto.Token = result.Token;
            loginDto.Expiration = result.Expiration;
            loginDto.RolId = userToLogin.RolId;
            loginDto.UserId = userToLogin.UserId;
            return Ok(loginDto);
        }
    }
}
