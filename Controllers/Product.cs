using Microsoft.AspNetCore.Mvc;

namespace TheITBooksOnlineShop.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<string>> GetProducts(){
        var products = new List<string>();
        products.Add("VueJS");
        products.Add("Fultter");
        products.Add("React");
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public ActionResult GetproductbyId(int id)
    {
        return Ok(new {productId = id ,name = "VueJS"});
    }

    [HttpGet("search/{id}/{catagory}")]
    public ActionResult SearchproductbyId(int id, string catagory)
    {
        return Ok(new {productId = id ,name = "ReactJS", cat = catagory});
    }

    [HttpGet("query/product")]
    public ActionResult QueryProductById([FromQuery] int id, [FromQuery] string catagory)
    {
        return Ok(new {productId = id, name = "Fultter",cat = catagory});
    }

    [HttpGet("queryv2/product/{user}")]
    public ActionResult QueryProductById([FromQuery] int id, [FromQuery] string catagory, string user)
    {
        return Ok(new {productId = id, name = "Fultter",cat = catagory, user = user});
    }
    
    [HttpPost]
    public ActionResult<Product> AddProduct([FromBody] Product product)
    {
       return Ok(product);
    }

    [HttpPost("add")]
    public ActionResult<Product> AddProductV2([FromBody] Product product)
    {
       return Ok(product);
    }
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }

}
