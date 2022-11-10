using Microsoft.AspNetCore.Mvc;
using _2022_10_22_WebApplication.Services.Lab5;

namespace _2022_10_22_WebApplication.Controllers.Lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
