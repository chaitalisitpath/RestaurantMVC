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
        public IActionResult Authenticate()
        {

            var items = _authenticate.Authenticate();
            return Ok(items);
        }
    }
}
