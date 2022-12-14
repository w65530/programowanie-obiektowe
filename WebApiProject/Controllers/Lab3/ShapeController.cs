using Microsoft.AspNetCore.Mvc;
using WebApiProject.Services.Lab3;

namespace WebApiProject.Controllers.Lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
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
        [HttpGet]
        public int GetShorterSide()
        {
            var rectangle = new Rectangle(3, 4);
            return rectangle.GetShorterSide();
        }
    }
}
