using Microsoft.EntityFrameworkCore;
using Prevozi.WebApi.Data;
using Prevozi.WebApi.Dtos;
using Prevozi.WebApi.Models;

namespace Prevozi.WebApi.Services;

public class AdminService
{
    private readonly AppDbContext _context;

    public AdminService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<User?> GetUser(int id)
    {
        return await _context.users.FindAsync(id);
    }

}