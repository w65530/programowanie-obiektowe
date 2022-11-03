using Microsoft.AspNetCore.Mvc;
using _2022_10_22_WebApplication.Services.Lab3;

namespace _2022_10_22_WebApplication.Controllers.Lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : Controller
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23, 24);
            return rectangle.GetArea();
        }
        [HttpGet]
        public int GetSumArea()
        {
            var rectangle = new Rectangle(3, 4);
            var rectangle2 = new Rectangle(4, 5);
            return rectangle + rectangle2;
        }
    }
}
