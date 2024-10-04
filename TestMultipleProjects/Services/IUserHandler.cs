using Microsoft.EntityFrameworkCore;
using TestMultipleProjects.Dto;
using TestMultipleProjects.Models;

namespace TestMultipleProjects.Services;

public interface IUserHandler
{
    
    Task<User> CreateUser(UserDto user);
    Task<List<User>> GetUsers();
    
}


public class UserHandler : IUserHandler
{
    private readonly ApplicationDbContext _context;
    
    public UserHandler(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<User> CreateUser(UserDto user)
    {
        var userEntity = new User
        {
            Name = user.Name,
            Email = user.Email
        };
        
        await _context.Users.AddAsync(userEntity);
        await _context.SaveChangesAsync();

        return userEntity;
    }
    
    public async Task<List<User>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }
    
    
    
}