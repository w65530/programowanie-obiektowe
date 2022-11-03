using Microsoft.AspNetCore.Mvc;
using _2022_10_22_WebApplication.Services.Lab4;

namespace _2022_10_22_WebApplication.Controllers.Lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            var lang1 = new Polish("pl");
            return lang1.getLang();
        }
    }
}
