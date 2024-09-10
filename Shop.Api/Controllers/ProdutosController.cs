using Microsoft.AspNetCore.Mvc;
using Shop.Api.Database.Context;

namespace Shop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProdutosController(ApiContext context) : ControllerBase
{
    [HttpGet]
    public IActionResult ObterProdutos()
    {
        return Ok(context.Products);
    }
}
