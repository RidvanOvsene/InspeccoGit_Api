using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Inspecco_Api.Contpermissionlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_permissionService.GetList());
        }

            [HttpGet("getbyid")]
        public IActionResult GetById(int PermissionId)
        {
            return Ok(_permissionService.GetById(PermissionId));
        }

        [HttpPost("add")]
        public IActionResult Add(Permission permission)
        {
            return Ok(_permissionService.Add(permission));
        }
        [HttpPost("update")]
        public IActionResult Update(Permission permission)
        {
            return Ok(_permissionService.Update(permission));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Permission permission)
        {
            return Ok(_permissionService.Delete(permission));
        }
    }
}
