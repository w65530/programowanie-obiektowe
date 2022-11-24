using Microsoft.AspNetCore.Mvc;
using ModelViewControllerProject.Models.Person;

namespace ModelViewControllerProject.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("### Person Controller ###");
            var model = new PersonViewModel()
            {
                People = new PersonModel().GetPeople()
            };
            return View(model);
        }
    }
}
