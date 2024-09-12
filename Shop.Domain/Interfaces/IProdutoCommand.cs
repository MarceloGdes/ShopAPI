using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.Dtos;

namespace Shop.Domain.Interfaces
{
    public interface IProdutoCommand
    {
        void AterarProduto(AlterarProdutoDto dto);

        int AdicionarProduto(AdicionarProdutoDto dto);

        void DeletarProduto(int id);

        ObterProdutoDto ObterProdutoPorId(int id);
    }
}
