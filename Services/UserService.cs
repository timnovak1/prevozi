using Microsoft.EntityFrameworkCore;
using Prevozi.WebApi.Data;
using Prevozi.WebApi.Dtos;
using Prevozi.WebApi.Models;


namespace Prevozi.WebApi.Services;

public class UserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<User?> ValidateUser(string email, string password)
    {
        var u = await _context.users
            .Include(u => u.carrier)
            .FirstOrDefaultAsync(u => u.email == email && u.password == password);
        return u;
    }

    /*
    public async Task<UserLoginTokenDto?> Login(UserLoginRequestDto userLoginRequestDto)
    {
        var u = _context.Users.FirstOrDefaultAsync(u =>
            u.Email == userLoginRequestDto.Email && u.Password == userLoginRequestDto.Password);

        if (u == null)
        {
            return null;
        }  
        
    }
    */
}