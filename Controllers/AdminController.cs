using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prevozi.WebApi.Dtos;
using Prevozi.WebApi.Models;
using Prevozi.WebApi.Services;



namespace Prevozi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdminController : ControllerBase
{
    private readonly AdminService _adminService;


    public AdminController(AdminService adminService)
    {
        _adminService = adminService;
    }

    
    [HttpGet("{id:int}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _adminService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }
    
}