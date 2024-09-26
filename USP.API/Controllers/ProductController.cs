using Microsoft.AspNetCore.Mvc;

namespace USP.API.Controllers;

public class ProductController : ApiBaseController
{
    
    [HttpGet]
    public string Get()
    {
        return "Petar";
    }

    [HttpPost]
    public string Create() => "Created!";
}