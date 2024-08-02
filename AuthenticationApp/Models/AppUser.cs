using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationApp.Models
{
    public class AppUser : IdentityUser //instead of using <identiyyuser> create our class and use this class features. 
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email {  get; set; }

    }
}
