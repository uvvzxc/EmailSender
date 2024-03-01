﻿using System.ComponentModel.DataAnnotations;

namespace RegisterGmail.Domain.Entities.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string UserName { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? confirmPassword { get; set; }
    }
}
