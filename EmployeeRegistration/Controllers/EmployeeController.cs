using Microsoft.AspNetCore.Mvc;

namespace EmployeeRegistration.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }
    }
}
