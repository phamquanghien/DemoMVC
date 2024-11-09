using Microsoft.AspNetCore.Identity;

namespace DemoMVC.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? FullName { get; set; }
    }
}