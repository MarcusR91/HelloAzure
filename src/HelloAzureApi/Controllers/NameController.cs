using Microsoft.AspNetCore.Mvc;

namespace HelloAzureApi.Controllers;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{




    [HttpGet(Name = "Name")]
    public ActionResult<string> GetName(int id)
    {
        return "Marcus Rosberg";

    }
}
