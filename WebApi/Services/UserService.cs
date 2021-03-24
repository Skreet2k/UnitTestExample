using System;
using System.Linq;
using WebApi.Entities;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        
        public User GetUser(long id)
        {
            var user = _repository.GetUsers().FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                throw new Exception($"User with Id {id} not found");
            }

            return user;
        }

        public int GetUserCount()
        {
            return _repository.GetUsers().Count();
        }

        public User AddUser(User user)
        {
            return _repository.AddUser(user);
        }
    }
}