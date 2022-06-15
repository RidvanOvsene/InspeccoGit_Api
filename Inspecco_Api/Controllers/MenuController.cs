using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Inspecco_Api.Contmenulers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_menuService.GetList());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int MenuId)
        {
            return Ok(_menuService.GetById(MenuId));
        }

        [HttpPost("add")]
        public IActionResult Add(Menu menu)
        {
            return Ok(_menuService.Add(menu));
        }
        [HttpPost("update")]
        public IActionResult Update(Menu menu)
        {
            return Ok(_menuService.Update(menu));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Menu menu)
        {
            return Ok(_menuService.Delete(menu));
        }
    }
}
