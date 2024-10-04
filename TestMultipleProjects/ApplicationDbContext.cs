using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using TestMultipleProjects.Models;

namespace TestMultipleProjects;

public class ApplicationDbContext : DbContext
{
    
    public DbSet<User> Users { get; set; }
    
    
    
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}