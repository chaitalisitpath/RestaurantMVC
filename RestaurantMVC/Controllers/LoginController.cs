using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.Services;

namespace RestaurantMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticate _authenticate;

        public LoginController(IAuthenticate authenticate)
        {
            _authenticate = authenticate;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            if(_authenticate.Authenticate(username, password))
            {
                return RedirectToAction("Menu", "Login");
            }
            ViewBag.ErrorMessage = "Please enter valid username and password";
            return View();
           
        }
        public IActionResult Menu()
        {
            return View();
        }

    }
}
