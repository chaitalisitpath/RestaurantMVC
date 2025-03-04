using System.ComponentModel.DataAnnotations;

namespace RestaurantMVC.Models
{
    public class LoginModel
    {
        [MinLength(8, ErrorMessage = "Please enter minimum 8 letters")]
        public string? username { get; set; }
        //    [Required]
        //    [MembershipPassword(
        //    MinRequiredNonAlphanumericCharacters = 1,
        //    MinNonAlphanumericCharactersError = "Your password needs to contain at least one symbol (!, @, #, etc).",
        //    ErrorMessage = "Your password must be 6 characters long and contain at least one symbol (!, @, #, etc).",
        //    MinRequiredPasswordLength = 6
        //)]
        //    [DataType(DataType.Password)]
        [Required]
        public string? password { get; set; }
    }
}
