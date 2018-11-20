namespace Chuska.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ChuskaUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
