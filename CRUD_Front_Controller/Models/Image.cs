using System.ComponentModel.DataAnnotations;

namespace CRUD_Front_Controller.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }


    }
}
