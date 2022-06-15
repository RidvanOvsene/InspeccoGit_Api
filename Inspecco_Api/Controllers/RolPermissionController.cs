using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Inspecco_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolPermissionController : ControllerBase
    {
        private readonly IRolPermissionService _rolPermissionService;
        public RolPermissionController(IRolPermissionService rolPermissionService)
        {
            _rolPermissionService = rolPermissionService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_rolPermissionService.GetList());
        }
        [HttpGet("GetListRolPermission")]
        public IActionResult GetListRolPermission()
        {
            return Ok(_rolPermissionService.GetListRolPermission());

        }
        [HttpGet("GetByRolId")]
        public IActionResult GetByRolId(int RolId)
        {
            return Ok(_rolPermissionService.GetByRoleId(RolId));
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int RolPermissionId)
        {
            return Ok(_rolPermissionService.GetById(RolPermissionId));
        }

        [HttpPost("add")]
        public IActionResult Add(RolPermission rolPermission)
        {
            return Ok(_rolPermissionService.Add(rolPermission));
        }
        [HttpPost("update")]
        public IActionResult Update(RolPermission rolPermission)
        {
            return Ok(_rolPermissionService.Update(rolPermission));
        }
        [HttpPost("delete")]
        public IActionResult Delete(RolPermission rolPermission)
        {
            return Ok(_rolPermissionService.Delete(rolPermission));
        }
    }
}
