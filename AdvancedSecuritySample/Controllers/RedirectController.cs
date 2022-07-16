using Microsoft.AspNetCore.Mvc;

namespace AdvancedSecuritySample.Controllers;

[ApiController]
[Route("[controller]")]
public class RedirectController : ControllerBase {

    [HttpGet(Name = "Hello")]
    public IActionResult Hello() {
       return Ok("Hello World");
    }

    [HttpGet(Name = "Redirect")]
    public IActionResult Get(string newURl) {
       return Redirect(newURl);
    }
}