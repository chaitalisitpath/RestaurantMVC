
namespace RestaurantMVC.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        public bool Authenticate(string username, string password)
        {
            return username == "chaitali" && password == "chaitali123";
        }
    }
}