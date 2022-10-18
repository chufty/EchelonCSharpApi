using Microsoft.AspNetCore.Mvc;

namespace EchelonCSharpApi.Hello;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet("{name}")]
    public HelloResult Get(string name) => new HelloResult(name);
}