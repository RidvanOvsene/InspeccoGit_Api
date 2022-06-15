using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Inspecco_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_personService.GetList());
        }
        [HttpGet("GetListPersonDto")]
        public IActionResult GetListUserMenu()
        {

            return Ok(_personService.GetListPersonDto());

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int PersonId)
        {
            return Ok(_personService.GetById(PersonId));
        }

        [HttpPost("add")]
        public IActionResult Add(Person person)
        {
            return Ok(_personService.Add(person));
        }
        [HttpPost("update")]
        public IActionResult Update(Person person)
        {
            return Ok(_personService.Update(person));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Person person)
        {
            return Ok(_personService.Delete(person));
        }
    }
}
