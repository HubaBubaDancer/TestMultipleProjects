using Microsoft.AspNetCore.Mvc;
using TestMultipleProjects.Dto;
using TestMultipleProjects.Models;
using TestMultipleProjects.Services;

namespace TestMultipleProjects.Controllers;



[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    
    private readonly IUserHandler _userHandler;

    public UserController(IUserHandler userHandler)
    {
        _userHandler = userHandler;
    }

    [HttpPost("create-user")]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserDto user)
    {
        var ans = await _userHandler.CreateUser(user);
        return Ok(ans);
    }

    [HttpGet("get-users")]
    public async Task<IActionResult> GetUsersAsync()
    {
        var users = await _userHandler.GetUsers();
        return Ok(users);
    }
    
    


}