using System.ComponentModel.DataAnnotations;

namespace Prevozi.WebApi.Models;

public class Carrier
{
    [Key]
    [StringLength(10)]
    public string registrationNumber { get; set; } = default!;
    public string name { get; set; } = default!;
    public string fullName { get; set; } = default!;
    public string address { get; set; } = default!;
    public string contactPerson { get; set; } = default!;
    [EmailAddress]
    public string contactEmail { get; set; } = default!;
    [Phone]
    public string contactPhone { get; set; } = default!; 
}