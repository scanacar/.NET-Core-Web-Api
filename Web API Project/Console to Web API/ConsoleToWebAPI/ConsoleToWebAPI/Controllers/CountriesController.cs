using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [BindProperty]
        public CountryModel Country { get; set; }
        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Country.Name}, Population = {this.Country.Population}, Area = {this.Country.Area}");
        }
    }
}
