using System.ComponentModel.DataAnnotations;

namespace SimpleProductApi.DTOs
{
    public class RegisterDto
    {
        public string Username { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [MinLength(4)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }

}
