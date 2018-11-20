using System;
using System.Collections.Generic;
using System.Text;

namespace Torshia.Models.ViewModels.Users
{
    public class RegisterViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
    }
}
