
namespace RestaurantMVC.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        public bool Authenticate(string username, string password)
        {
            return username == "Chaitali" && password == "Chaitali123";
        }
    }
}