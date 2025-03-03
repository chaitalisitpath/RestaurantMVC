namespace RestaurantMVC.Services
{
    public interface IAuthenticateService
    {
       public bool Authenticate(string username, string password);
        
    }
}
