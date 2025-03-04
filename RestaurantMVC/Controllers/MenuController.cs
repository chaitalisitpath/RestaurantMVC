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
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
               return RedirectToAction("Login", "Login");
            }
            else { 
                
                ViewBag.WelcomeMessage = "Welcome " + HttpContext.Session.GetString("User") + " ...!!";
                var items = _menu.GetItems();
                return View(items);
            }
        }
       

        
    }
}
