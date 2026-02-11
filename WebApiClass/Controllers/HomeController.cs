using Microsoft.AspNetCore.Mvc;

namespace WebApiClass.Controllers;

//[Route("api/[controller]/any-staticname")]
//[Route("api/[controller]/[action]")]
 [Route("api/[controller]")]

[ApiController]
public class HomeController : ControllerBase
{
   // [HttpGet("new-name")]
    //[HttpGet("/new-name")]
    [HttpGet]
    public void Get()
    {

    }

    [HttpGet("intvalue")]
    public int GetReturnInt()
    {
        return 100;
    }

}
