using System.ComponentModel.DataAnnotations;

namespace PatikaIdentity.Request
{
    public class UserRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
    }
}
