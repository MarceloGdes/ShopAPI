using Microsoft.AspNetCore.Mvc;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;

namespace Shop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProdutosController(ApiContext context, IProdutoCommand command) : ControllerBase
{
    [HttpGet] //Define o método HTTP
    public IActionResult ObterProdutos()
    {
        return Ok(context.Products);
    }

    [HttpPut]
    public IActionResult EditarProduto([FromBody] AlterarProdutoDto dto)
    {
        command.AterarProduto(dto);
        return Ok();
    }

    [HttpPost]
    public IActionResult AdicionarProduto([FromBody] AdicionarProdutoDto dto)
    {
        
        return Ok(command.AdicionarProduto(dto));
    }

    [HttpDelete("{id}")] //id na rota
    public IActionResult DeletarProduto([FromRoute] int id)
    {
        command.DeletarProduto(id);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult ObterProdutoPorId([FromRoute]int id)
    {   

        return Ok(command.ObterProdutoPorId(id));
    }
}
