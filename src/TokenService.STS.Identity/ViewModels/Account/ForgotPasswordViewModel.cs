﻿using Skoruba.Duende.IdentityServer.Shared.Configuration.Configuration.Identity;
using System.ComponentModel.DataAnnotations;

namespace TokenService.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}








