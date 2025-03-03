using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.Services;
namespace RestaurantMVC.Controllers
{
    public class MenuController :Controller
    {
        private readonly IMenuService _menu;

       public MenuController(IMenuService menu)
       {
            _menu = menu;
       }
        public IActionResult Menu()
        {
            if(HttpContext.Session.GetString("User")==null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Login");
            }
            var items = _menu.GetItems();
            return View(items);
        }

        
    }
}
