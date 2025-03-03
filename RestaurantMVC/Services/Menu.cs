using RestaurantMVC.Models;

namespace RestaurantMVC.Services
{
    public class Menu : IMenu
    {
        //List<MenuModel> m = new List<MenuModel>();
        public IEnumerable<MenuModel> GetItems()
        {
            return new List<MenuModel>()
            { 
                new MenuModel {DishName = "Pizza", Price = 200},
                new MenuModel {DishName = "Dal Baati", Price = 140},
                new MenuModel {DishName = "Pasta", Price = 250},
                new MenuModel {DishName = "French Fries", Price = 120},
                new MenuModel {DishName = "Panini", Price = 230},
                new MenuModel {DishName = "Manchurian", Price = 150},
                new MenuModel {DishName = "Burger", Price = 50},
                new MenuModel {DishName = "Taco", Price = 80},
                new MenuModel {DishName = "Hot and Sour Soup", Price = 120},
                new MenuModel {DishName = "Idli", Price = 70},
                new MenuModel {DishName = "Ghotala Dosa", Price = 280}
            };

        }
    }
}
