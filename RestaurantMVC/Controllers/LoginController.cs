using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.Services;

namespace RestaurantMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticateService _authenticate;

        public LoginController(IAuthenticateService authenticate)
        {
            _authenticate = authenticate;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
           if(_authenticate.Authenticate(username, password))
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Menu", "Menu");
            }
            ViewBag.ErrorMessage = "Please enter valid username and password";
            return View();
           
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Login");
        }


    }
}
