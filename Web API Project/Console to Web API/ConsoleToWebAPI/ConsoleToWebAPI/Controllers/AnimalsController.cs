using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() { Id = 1, Name = "Dog" },
                new AnimalModel() { Id = 2, Name = "Dog2"}
            };
        }
        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {

            return Ok(animals);
        }
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {

            return AcceptedAtRoute("All");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var animal = animals.FirstOrDefault(x => x.Id == id);

            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);
            return Created("~/api/animals/" + animal.Id, animal);
        }
    }
}
