using Microsoft.AspNetCore.Mvc;

namespace HelloAzureApi.Controllers;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{


    // [HttpGet(Name = "Message")]
    // public ActionResult<string> GetMessage()
    // {
    //     return "Hej Babat";
    // }

    [HttpGet(Name = "Name")]
    public ActionResult<string> GetName(int id)
    {
        return "Marcus Rosberg";

    }
}
