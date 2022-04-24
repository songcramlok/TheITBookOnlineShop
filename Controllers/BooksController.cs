using Microsoft.AspNetCore.Mvc;

namespace TheITBooksOnlineShop.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    [HttpGet]
    public ActionResult GetBooks()
    {
        return Ok("i iam groot");
    }
}
