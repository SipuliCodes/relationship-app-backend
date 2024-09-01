using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TestController : Controller
{
    public TestController()
    {
    }

    [HttpGet]
    public ActionResult<string> Get() => "Test";
}