namespace Torshia.Services.Contracts
{
    using Torshia.Models;

    public interface IUserService
    {
        bool RegisterUser(string username, string password, string email);

        User FindUser(string username, string password);

        bool IsUserExists(string username, string password);

        bool IsAdmin(string username);
    }
}
