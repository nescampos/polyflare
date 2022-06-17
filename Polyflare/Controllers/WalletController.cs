using Microsoft.AspNetCore.Mvc;

namespace KlaytonWeb.Controllers
{
    public class WalletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateTransaction()
        {
            return View();
        }

        public IActionResult Transactions()
        {

            return View();
        }

        public ActionResult Pools()
        {
            return View();
        }



    }
}
