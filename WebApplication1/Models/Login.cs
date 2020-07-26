using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter your email")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}