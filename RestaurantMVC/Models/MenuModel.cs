using System.ComponentModel.DataAnnotations;

namespace RestaurantMVC.Models
{
    public class MenuModel
    {
        [Display(Name = "Dish Name")]
        public string? DishName { get; set; }

        [Display(Name = "Price (Rupees)")]
        public decimal Price { get; set; }
    }
}
