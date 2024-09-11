using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Interfaces;

namespace Shop.Application.Commands
{
    public class AlterarProdutoCommand(ApiContext context) : IAlterarProdutoCommand
    {
        public void AterarProduto(AlterarProdutoDto dto)
        {
            var produto = context.Products.FirstOrDefault(x => x.Id == dto.Id);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado");

            }

            produto.Nome = dto.Nome;
            produto.Preco = dto.Preco;

            context.SaveChanges();
        }
    }
}
