﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_Front_Controller.Models.ViewModel
{
    public class ImageCreateModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please choose ImageFile")]
        [Display(Name="Choose Image")]
        public IFormFile ImagePath { get; set; }
    }
}
