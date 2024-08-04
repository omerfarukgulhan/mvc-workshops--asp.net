using Microsoft.AspNetCore.Identity;

namespace identity.Data
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
