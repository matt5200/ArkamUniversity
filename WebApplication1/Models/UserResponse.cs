using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Please enter your email")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string UserPassword { get; set; }
        [Compare("UserPassword", ErrorMessage = "Password's don't match. Enter again.")]
        public string ConfirmPassword { get; set; }
    }
}