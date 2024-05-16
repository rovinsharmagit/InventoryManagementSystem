using Microsoft.AspNetCore.Identity;

namespace Application.Extensions.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
