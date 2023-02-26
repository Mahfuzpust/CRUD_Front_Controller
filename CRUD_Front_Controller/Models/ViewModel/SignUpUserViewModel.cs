﻿using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CRUD_Front_Controller.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter mobile number")]
        public long Mobile { get; set; }

        [Required(ErrorMessage ="please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "please enter Confirmpassword")]
        [Compare("Password", ErrorMessage = ("confirm password can not match"))]
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
    }
}
