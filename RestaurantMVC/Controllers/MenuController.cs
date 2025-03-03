using Microsoft.AspNetCore.Mvc;
using RestaurantMVC.Services;
namespace RestaurantMVC.Controllers
{
    public class MenuController :Controller
    {
        private readonly IMenu _menu;

       public MenuController(IMenu menu)
       {
            _menu = menu;
       }
        public IActionResult Menu()
        {
            var items = _menu.GetItems();
            return View(items);
        }
    }
}
