
using System.ComponentModel.DataAnnotations;

namespace PatikaIdentity.Entites
{
    public class UserEntitiy : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password  { get; set; }
    
    }
}
