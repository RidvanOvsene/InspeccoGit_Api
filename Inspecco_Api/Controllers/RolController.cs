using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Inspecco_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;
        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_rolService.GetList());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int RolId)
        {
            return Ok(_rolService.GetById(RolId));
        }

        [HttpPost("add")]
        public IActionResult Add(Rol rol)
        {
            return Ok(_rolService.Add(rol));
        }
        [HttpPost("update")]
        public IActionResult Update(Rol rol)
        {
            return Ok(_rolService.Update(rol));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Rol rol)
        {
            return Ok(_rolService.Delete(rol));
        }
    }
}
