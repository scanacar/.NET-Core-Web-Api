using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
        //[Route("getall")]
        //[Route("get-all")]
        //[Route("[controller]/[action]")]
        //[Route("[action]/[controller]")]

        // if we want to override route we can write [Route("~/get-all")] 
        public string GetAll()
        {
            return "hello from get all";
        }

        //[Route("api/get-all-authors")]
        //[Route("[controller]/[action]")]
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello " + id + " " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }
    }
}
