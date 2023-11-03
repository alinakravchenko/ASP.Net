using Microsoft.AspNetCore.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(contact);
                return View("Thanks", contact);
            }
            return View("Index");
        }
        public IActionResult ListResponses() 
        {
            return View(Repository.Contacts);
                }
    }
}
   