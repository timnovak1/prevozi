namespace Prevozi.WebApi.Services;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Prevozi.WebApi.Models;

public class TokenService
{
    private readonly JwtOptions _opts;
    private readonly byte[] _keyBytes;

    public TokenService(IOptions<JwtOptions> opts)
    {
        _opts = opts.Value;
        _keyBytes = Encoding.UTF8.GetBytes(_opts.key);
    }

    public string GenerateToken(User user)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.email),
            new(ClaimTypes.Role, user.userRole.ToString())
        };
        
        //todo: flitreranje po carriers - if needed
        if (!string.IsNullOrWhiteSpace(user.carrierRegistrationNumber))
        {
            claims.Add(new("carrierRegNo", user.carrierRegistrationNumber!));
        }

        var creds = new SigningCredentials(
            new SymmetricSecurityKey(_keyBytes),
            SecurityAlgorithms.HmacSha256);

        var jwt = new JwtSecurityToken(
            issuer: _opts.issuer,
            audience: _opts.audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddMinutes(_opts.expMinutes),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}