using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;

namespace Shop.Application.Commands;
internal class PedidoCommand(ApiContext context) : IPedidoCommand
{
    public List<ObterPedidosDto> ObterPedidos()
    {
        var pedidos = new List<ObterPedidosDto>();

        foreach(var item in context.Orders)
        {
            item.CalcularValorTotal();

            var pedido = new ObterPedidosDto()
            {
                Id = item.Id,
                Endereco = item.Endereco,
                NomeCliente = item.NomeCliente,
                Produtos = item.Produtos,
                ValorTotal = item.ValorTotal,
            };

            pedidos.Add(pedido);
        }

        return pedidos;

    }
}
