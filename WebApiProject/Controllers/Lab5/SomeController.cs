using Microsoft.AspNetCore.Mvc;
using WebApiProject.Services.Lab5;

namespace WebApiProject.Controllers.Lab5
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
