using Microsoft.AspNetCore.Mvc;

namespace Prevozi.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    [HttpGet]
    public string Index()
    {
        return "This is my default action...";
    }
    
    // GET: /HelloWorld/Welcome/
    [HttpGet("welcome")]
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}