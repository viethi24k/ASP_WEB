using Microsoft.AspNetCore.Mvc;
using MultiplicationTableApp.Services;

namespace MultiplicationTableApp.Controllers
{
    public class MultiplicationController : Controller
    {
        private readonly MultiplicationTableService _service;

        public MultiplicationController(MultiplicationTableService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var table = _service.GetMultiplicationTable();
            return View(table);
        }
    }
}
