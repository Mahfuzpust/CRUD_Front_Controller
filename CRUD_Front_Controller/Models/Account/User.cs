using System.ComponentModel.DataAnnotations;

namespace CRUD_Front_Controller.Models.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemember { get; set;}

    }
}
