using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Api.Database.Context;
using Shop.Domain.Dtos;
using Shop.Domain.Entidades;
using Shop.Domain.Interfaces;

namespace Shop.Application.Commands
{
    public class ProdutoCommand(ApiContext context) : IProdutoCommand
    {
        public int AdicionarProduto(AdicionarProdutoDto dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco
            };

            context.Add(produto);
            context.SaveChanges();

            return produto.Id;
        }

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

        public void DeletarProduto(int id)
        {
            var produto = context.Products.FirstOrDefault(x => x.Id == id); //Percorre a lista dos produtos buscando o id

            if(produto == null)
                throw new Exception("Produto não encontrado.");

            context.Remove(produto);
            context.SaveChanges();
        }

        public ObterProdutoDto ObterProdutoPorId(int id)
        {
            var produto = context.Products.FirstOrDefault(x => x.Id == id);

            if (produto == null)
                throw new Exception("Produto não encontrado.");

            var dto = new ObterProdutoDto
            {
                Id = id,
                Nome = produto.Nome,
                Preco = produto.Preco,
            };

            return dto;
            
        }



    }
}
