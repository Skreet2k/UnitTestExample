using System.Linq;
using WebApi.Repositories;
using Xunit;

namespace WebApiTests.Repositories
{
    public class InMemoryRepositoryTests
    {
        [Fact]
        public void GetUsers_ShouldReturn_UserList()
        {
            //arrange
            var repository = new InMemoryRepository();
            
            //act
            var result = repository.GetUsers();
            
            //assert
            Assert.Null(result);
        }
        
        [Fact]
        public void GetUsers_ShouldReturn_TwoUsers()
        {
            //arrange
            const int expectedCount = 2;
            var repository = new InMemoryRepository();
            
            //act
            var result = repository.GetUsers();
            
            //assert
            Assert.Equal(expectedCount, result.Count());
        }
    }
}