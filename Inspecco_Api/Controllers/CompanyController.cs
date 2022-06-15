using Business.Services.Interfeces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Inspecco_Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_companyService.GetList());
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int CompanyId)
        {
            return Ok(_companyService.GetById(CompanyId));
        }

        [HttpPost("add")]
        public IActionResult Add(Company company)
        {
            return Ok(_companyService.Add(company));
        }
        [HttpPost("update")]
        public IActionResult Update(Company company)
        {
            return Ok(_companyService.Update(company));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Company company)
        {
            return Ok(_companyService.Delete(company));
        }
    }
}
