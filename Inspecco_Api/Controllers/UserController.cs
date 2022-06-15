using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inspecco_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_userService.GetList());
        }
        [HttpGet("GetListUserRol")]
        public IActionResult GetListUserRol()
        {

            return Ok(_userService.GetListUserRol());

        }
        [HttpGet("Login")]
        public IActionResult Login(string UserName, string Password)
        {
            return Ok(_userService.Login(UserName, Password));
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int UserId)
        {
            return Ok(_userService.GetById(UserId));
        }

        [HttpPost("add")]
        public IActionResult Add(Users users)
        {
            return Ok(_userService.Add(users));
        }
        [HttpPost("update")]
        public IActionResult Update(Users users)
        {
            return Ok(_userService.Update(users));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Users users)
        {
            return Ok(_userService.Delete(users));
        }
    }
}