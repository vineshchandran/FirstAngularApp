using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify pasword between 4 nad 8")]
        public string Password { get; set; }
    }
}
