using System.Text.Json.Serialization;
using Prevozi.WebApi.Models;

namespace Prevozi.WebApi.Dtos;

public record UserDto
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public UserRole userRole { get; set; }
    
    public UserDto(User user)
    {
        this.id =  user.id;
        this.firstName = user.firstName;
        this.lastName = user.lastName;
        this.email = user.email;
        this.userRole = user.userRole;
    }


};
