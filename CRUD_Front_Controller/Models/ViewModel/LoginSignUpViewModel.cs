using System.ComponentModel.DataAnnotations;

namespace CRUD_Front_Controller.Models.ViewModel
{
    public class LoginSignUpViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        [Display(Name ="Remember Me")]
        public bool IsRemember { get; set; }
    }
}
