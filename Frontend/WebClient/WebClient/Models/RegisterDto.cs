﻿using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "User Name is required.")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; init; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; init; }
    }
}
