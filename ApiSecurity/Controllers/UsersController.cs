using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IConfiguration config;

    public UsersController(IConfiguration config)
    {
        this.config = config;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] {"value1", "value2"};
    }

    [HttpGet("id")]
    public string Get(string id)
    {
        return config.GetConnectionString(id)! /*?? throw new Exception("Missing connection string")*/;
    }
}
