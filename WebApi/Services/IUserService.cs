using WebApi.Entities;

namespace WebApi.Services
{
    public interface IUserService
    {
        User GetUser(long id);
        int GetUserCount();
        User AddUser(User user);
    }
}