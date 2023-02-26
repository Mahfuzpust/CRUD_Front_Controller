using System.ComponentModel.DataAnnotations;

namespace CRUD_Front_Controller.Models.ViewModel
{
    public class LoginSignUpViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        [Display(Name ="Remember Me")]
        public bool IsRemember { get; set; }
    }
}
