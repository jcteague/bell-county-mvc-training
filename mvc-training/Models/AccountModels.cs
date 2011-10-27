﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTraining.Validation;

namespace MvcTraining.Models {

    

//    public class ChangePasswordModel {
//        [Required]
//        [DataType(DataType.Password)]
//        [Display(Name = "Current password")]
//        public string OldPassword { get; set; }
//
//        [Required]
//        [DataType(DataType.Password)]
//        [Display(Name = "New password")]
//        public string NewPassword { get; set; }
//
//        [DataType(DataType.Password)]
//        [Display(Name = "Confirm new password")]
//        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
//        public string ConfirmPassword { get; set; }
//    }

    public class LogOnModel {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }


//    public class RegisterModel {
//        [Required]
//        [Display(Name = "User name")]
//        public string UserName { get; set; }
//
//        [Required]
//        [DataType(DataType.EmailAddress)]
//        [Display(Name = "Email address")]
//        public string Email { get; set; }
//
//        [Required]
//        [ValidatePasswordLength]
//        [DataType(DataType.Password)]
//        [Display(Name = "Password")]
//        public string Password { get; set; }
//
//        [DataType(DataType.Password)]
//        [Display(Name = "Confirm password")]
//        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
//        public string ConfirmPassword { get; set; }
//    }
 
}
