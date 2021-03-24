using System.Collections.Generic;
using WebApi.Entities;

namespace WebApi.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User AddUser(User user);
    }
}