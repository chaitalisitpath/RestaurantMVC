using System.Reflection.Metadata.Ecma335;
using RestaurantMVC.Models;

namespace RestaurantMVC.Services
{
    public interface IMenuService
    {
        IEnumerable<MenuModel> GetItems();
        
    }
}
