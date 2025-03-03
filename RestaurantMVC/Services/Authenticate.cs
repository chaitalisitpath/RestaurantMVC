
namespace RestaurantMVC.Services
{
    public class Authenticate : IAuthenticate
    {
        bool IAuthenticate.Authenticate(string username, string password)
        {
            return username == "chaitali" && password == "chaitali123";
        }
    }
}