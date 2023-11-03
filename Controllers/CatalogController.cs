using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
