namespace Prevozi.WebApi.Models;

public class User
{
    public int id { get; set; } = default!;
    public string firstName { get; set; } = default!;
    public string lastName { get; set; } = default!;
    public string email { get; set; } = default!;
    public string password { get; set; } = default!;
    public UserRole userRole { get; set; }
    
    public string? carrierRegistrationNumber { get; set; }
    public Carrier? carrier { get; set; }
}