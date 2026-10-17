using Microsoft.AspNetCore.Mvc;

namespace UniversalNotes.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}