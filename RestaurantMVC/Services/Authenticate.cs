
namespace RestaurantMVC.Services
{
    public class Authenticate : IAuthenticate
    {
        string uname = "chaitali";
        string pw = "chaitali123";
        bool IAuthenticate.Authenticate(string username, string password)
        {
            
            if(username==uname && password==pw)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}