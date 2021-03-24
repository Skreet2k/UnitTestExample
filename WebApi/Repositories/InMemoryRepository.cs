using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;

namespace WebApi.Repositories
{
    public class InMemoryRepository: IUserRepository
    {
        private readonly List<User> _users;

        public InMemoryRepository()
        {
            _users = new List<User> {new() {Id = 1, Name = "Alex"}, new() {Id = 2, Name = "Mikhail"}};
        }
        
        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User AddUser(User user)
        {
            if (_users.Any(u => u.Id == user.Id))
            {
                throw new Exception($"User with Id '{user.Id}' exists");
            }

            _users.Add(user);

            return user;
        }
    }
}