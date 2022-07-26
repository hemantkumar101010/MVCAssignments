using Microsoft.AspNetCore.Mvc;

namespace PracticeControllerViews.Controllers
{
    public class PracticeRazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
