using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Inspecco_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMenuController : ControllerBase
    {
        private readonly IUserMenuService _userUserMenuService;
        public UserMenuController(IUserMenuService userUserMenuService)
        {
            _userUserMenuService = userUserMenuService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_userUserMenuService.GetList());
        }
        [HttpGet("GetListUserMenu")]
        public IActionResult GetListUserMenu()
        {

            return Ok(_userUserMenuService.GetListUserMenu());

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int UserMenuId)
        {
            return Ok(_userUserMenuService.GetById(UserMenuId));
        }

        [HttpPost("add")]
        public IActionResult Add(UserMenu userUserMenu)
        {
            return Ok(_userUserMenuService.Add(userUserMenu));
        }
        [HttpPost("update")]
        public IActionResult Update(UserMenu userUserMenu)
        {
            return Ok(_userUserMenuService.Update(userUserMenu));
        }
        [HttpPost("delete")]
        public IActionResult Delete(UserMenu userUserMenu)
        {
            return Ok(_userUserMenuService.Delete(userUserMenu));
        }
    }
}
