using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC_LoginPage.Models
{
    public class RegisterClass
    {
        [Required(ErrorMessage = "Enter username !")]
        [Display(Name = "UserName :")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "Username Length Must Be Max 7 & Min 3")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the Email Address !")]
        [Display(Name = "Email ID :")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Enter the Password !")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter the RePassword !")]
        [Display(Name = "Re-Password :")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Select the Gender !")]
        [Display(Name = "Gender :")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "Please Fill The Details !")]
        [Display(Name = "What is Your Pet Name :")]
        public string Question1 { get; set; }

        [Required(ErrorMessage = "Please Fill The Details !")]
        [Display(Name = "What is Your Place Of Birth :")]
        public string Question2 { get; set; }
    }
}
  