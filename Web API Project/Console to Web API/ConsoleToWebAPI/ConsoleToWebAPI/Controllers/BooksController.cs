using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "hello int" + id;
        }

        [Route("{id:minlength(10):maxlength(20):alpha}")]
        public string GetByIdString(string id)
        {
            return "hello string" + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "hello regex" + id;
        }
    }
}
