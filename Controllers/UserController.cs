using Microsoft.AspNetCore.Mvc;

namespace TheITBooksOnlineShop.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public ActionResult Register(string username, string password, string fullname)
    {
        return Ok(new {id = username, pw = password, fN = fullname});
    }
    
    
    
}
