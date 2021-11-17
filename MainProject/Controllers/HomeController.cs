﻿using Microsoft.AspNetCore.Mvc;
using MyLibrary;

namespace MainProject.Controllers
{
    [Route("api/Home")]
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
