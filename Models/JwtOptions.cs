namespace Prevozi.WebApi.Models;

public class JwtOptions
{
    public string key { get; set; } = string.Empty;
    public string issuer { get; set; } = string.Empty;
    public string audience { get; set; } = string.Empty;
    public int expMinutes { get; set; } = 60;
}