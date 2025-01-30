using Microsoft.AspNetCore.Mvc;

namespace PersonalFinancePlatformAPI.Presentation.Controllers;

[Route("api/controller")]
[ApiController]
public class UserController : Controller
{
    [HttpGet("get-users")]
    public async Task<IActionResult> GetUsers()
    {
        return Ok();
    }
}
