using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

[Authorize]
[ApiController]
[Route("[controller]")]
[RequiredScope("relationshipapp.read")]
public class SecretController: ControllerBase
{
    private readonly ILogger<SecretController> _logger;
    private readonly IHttpContextAccessor _contextAccessor;

    public SecretController(ILogger<SecretController> logger, IHttpContextAccessor contextAccessor)
    {
        _logger = logger;
        _contextAccessor = contextAccessor;
    }

    [HttpGet]
    public ActionResult<string> Get() => "TestSecret"; 
}