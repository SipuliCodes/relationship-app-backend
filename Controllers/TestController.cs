using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
  public TestController()
  {
  }

  [HttpGet]
  public ActionResult<string> Get() => "Test";
}