﻿using BExIS.Utils.Filters;
using System.ComponentModel.DataAnnotations;

namespace BExIS.Web.Shell.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string Action { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "Authenticator")]
        public string Authenticator { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }

    public class ManageUserViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Terms and Conditions")]
        [MustBeTrue(ErrorMessage = "You must agree to the Terms and Conditions before register.")]
        public bool TermsAndConditions { get; set; }

        [Display(Name = "Inform")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Inform { get; set; }

        [Display(Name = "DOI")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool DOI { get; set; }

        [Display(Name = "Credit")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Credit { get; set; }

        [Display(Name = "PHD")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool PHD { get; set; }

        [Display(Name = "Forward")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Forward { get; set; }

        [Display(Name = "Metadata")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Metadata { get; set; }

        [Display(Name = "Verify")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Verify { get; set; }

        [Display(Name = "Data")]
        [MustBeTrue(ErrorMessage = ".......")]
        public bool Data { get; set; }

    }

    public class ResetPasswordViewModel
    {
        public string Code { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}