using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Services;
using Xunit;
using Moq;
using WebApi.Repositories;

namespace WebApiTests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public void GetUser_WithExistUser_ShouldReturn_User()
        {
            //arrange
            var user = new User {Id = 5, Name = "Vasya"};
            var users = new List<User> {user};
            
            var userRepositoryMock = new Mock<IUserRepository>();
            
            userRepositoryMock.Setup(r => r.GetUsers()).Returns(users);
            
            var service = new UserService(userRepositoryMock.Object);
            
            //act
            var result = service.GetUser(user.Id);
            
            //assert
            Assert.Equal(user, result);
        }

        [Fact]
        public void GetUser_WithNotExistUser_ShouldReturn_Exception()
        {
            //arrange
            const int notExistUserId = 1;
            var users = Enumerable.Empty<User>();
            
            var userRepositoryMock = new Mock<IUserRepository>();
            
            userRepositoryMock.Setup(r => r.GetUsers()).Returns(users);
            
            var service = new UserService(userRepositoryMock.Object);
            
            //act
            var result = Record.Exception(() => service.GetUser(notExistUserId));
            
            //assert
            Assert.NotNull(result);
        }
    }
}