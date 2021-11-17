using Microsoft.AspNetCore.Mvc;
using MyLibrary;

namespace MainProject.Controllers
{
    [Route("Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("Get")]
        public string Get()
        {
            return Constants.HelloWorld;
        }
    }
}
