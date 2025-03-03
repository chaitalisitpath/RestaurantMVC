namespace RestaurantMVC.Services
{
    public interface IAuthenticate
    {
       public bool Authenticate(string username, string password);
        
    }
}
