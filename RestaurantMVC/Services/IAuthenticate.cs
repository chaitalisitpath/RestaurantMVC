namespace RestaurantMVC.Services
{
    public interface IAuthenticate
    {
       bool Authenticate(string username, string password);
        
    }
}
