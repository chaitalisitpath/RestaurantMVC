
namespace RestaurantMVC.Services
{
    public class AuthenticateService : IAuthenticate
    {
       

        public List<string> Authenticate()
        {
            return new List<string>() { "item1", "item2"};
        }
    }
}