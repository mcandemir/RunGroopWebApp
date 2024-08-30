using Microsoft.AspNetCore.Mvc;

namespace RunGroopWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
