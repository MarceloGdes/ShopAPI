using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.Dtos;

namespace Shop.Domain.Interfaces;
public interface IPedidoCommand
{
    List<ObterPedidosDto> ObterPedidos();
}
