using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloworldService;

    public HelloWorldController(IHelloWorldService hellowoworld)
    {
        helloworldService = hellowoworld;
    }

    public IActionResult Get() 
    {
        return Ok(helloworldService.GetHelloWorld());
    }
}