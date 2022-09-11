using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIBook.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookControllers : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public string Get()
        {
            return "sample";
        }
        [HttpPost]
        [Route("subscription")]
        public string subscribe(string title, string author, int evaluation)
        {
            string _title = title;

            string _author = author;

            int _evaluation = evaluation;

            string res = string.Format("This is a {0} by {1}. my evaluation is {2}", _title, _author, _evaluation);
            return res;
        }
    }
}