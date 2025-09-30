using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Prevozi.WebApi.Dtos;
using Prevozi.WebApi.Models;
using Prevozi.WebApi.Services;

namespace Prevozi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    private readonly TokenService _tokenService;
    
    public UserController(UserService userService, TokenService tokenService)
    {
        _userService = userService;
        _tokenService = tokenService;
        
    }
    

    [HttpPost("login")]
    [ProducesResponseType(typeof(TokenResponseDto), 200)]
    [ProducesResponseType(401)]
    public async Task<ActionResult<TokenResponseDto>> Login([FromBody] UserLoginRequestDto userLoginRequestDto)
    {
        var user = await _userService.ValidateUser(userLoginRequestDto.Email, userLoginRequestDto.Password);
        if (user == null)
        {
            return Unauthorized();
        }
        var token = _tokenService.GenerateToken(user);
        var userDto = new UserDto(user);
        


        return Ok(new TokenResponseDto(token, userDto));
    }

}