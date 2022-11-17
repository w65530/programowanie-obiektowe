using Microsoft.AspNetCore.Mvc;
using WebApiProject.Services.Lab4;

namespace WebApiProject.Controllers.Lab4
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
