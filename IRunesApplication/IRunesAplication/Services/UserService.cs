namespace IRunesAplication.Services
{
    using Data;
    using Data.Models;
    using System.Linq;
    using Services.Contracts;

    public class UserService : IUserService
    {
        public bool Create(
            string username,
            string password,
            string email)
        {
            using (var db = new IRunesDbContext())
            {
                var isExists = db.Users.Any(u => u.Username == username);

                if (isExists)
                {
                    return false;
                }

                var user = new User()
                {
                    Username = username,
                    Password = password,
                    Email = email
                };

                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }

        public bool IsExist(string username, string password)
        {
            using (var db = new IRunesDbContext())
            {
                return db.Users.Any(u => u.Username == username && u.Password == password);
            }
        }
    }
}
