namespace Eventures.Models
{
    using Eventures.Models.Enum;
    using Microsoft.AspNetCore.Identity;

    public class EventuresUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UCN { get; set; }
        public RoleType Role { get; set; }
    }
}
