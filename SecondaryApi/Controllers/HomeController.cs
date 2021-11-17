using Microsoft.AspNetCore.Mvc;
using MyLibrary;

namespace SecondaryApi.Controllers
{
    [ApiController]
    [Route("api/Home")]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet("Get")]
        public string Get()
        {
            return Constants.Goodbye;
        }
    }
}
