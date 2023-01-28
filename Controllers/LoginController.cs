using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeSquad.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
