namespace IRunesAplication.Services.Contracts
{
    public interface IUserService
    {
        bool Create(string username, string password, string email);

        bool IsExist(string username, string password);
    }
}
