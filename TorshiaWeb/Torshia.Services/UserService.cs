namespace Torshia.Services
{
    using Contracts;
    using Torshia.Data;
    using Torshia.Models;
    using System.Linq;
    using Torshia.Models.Enums;
    using System.Web;

    public class UserService : IUserService
    {
        private readonly TorshiaContext db;
        public UserService(TorshiaContext db)
        {
            this.db = db;
        }
        public bool RegisterUser(string username, string password, string email)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(email))
                {
                    return false;
                }
                var role = db.Users.Any() ? Role.User : Role.Admin;

                var user = new User
                {
                    Username = username,
                    Password = password,
                    Email = HttpUtility.UrlDecode(email),
                    Role = role
                };

                db.Users.Add(user);
                db.SaveChanges();
                return true;
        }

        public bool IsUserExists (string username, string password) 
            => db.Users
            .Any(u => u.Username == username && u.Password == password);

        public User FindUser(string username, string password)
            => db.Users
            .First(u => u.Username == username && u.Password == password);

        public bool IsAdmin(string username)
        {
            var user = db.Users.First(u => u.Username == username);
            if (user.Role == Role.User)
            {
                return false;
            }
            return true;
        }
    }
}
