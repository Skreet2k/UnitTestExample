using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet("{id}")]
        public User GetUser([FromRoute] long id)
        {
            return _userService.GetUser(id);
        }
        
        [HttpPost]
        public User AddUser([FromBody] User user)
        {
            return _userService.AddUser(user);
        }
        
        [HttpGet("count")]
        public int GetUserCount()
        {
            return _userService.GetUserCount();
        }

    }
}