using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Api.Database.Context;
using Shop.Domain.Interfaces;

namespace Shop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PedidosController(
    ApiContext context, IPedidoCommand pedidoCommand, IProdutoCommand produtoCommand) : ControllerBase
{
    [HttpGet]
    public IActionResult ObterPedidos()
    {
        return Ok(pedidoCommand.ObterPedidos());
    }


}
