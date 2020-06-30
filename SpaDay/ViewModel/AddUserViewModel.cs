using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Username must be between 5 and 15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters")]
        [PasswordPropertyText]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("Password", ErrorMessage ="Password and verify password must match")]
        public string VerifyPassword { get; set; }
    }
}
