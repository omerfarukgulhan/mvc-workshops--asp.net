using System.ComponentModel.DataAnnotations;

namespace identity.Models
{
    public class CreateUserModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password missmatch.")]
        public string ConfirmPassword { get; set; }
    }
}
