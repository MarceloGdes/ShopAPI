using Shop.Domain.Entidades;

namespace Shop.Domain.Dtos;
public class ObterPedidosDto
{
    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
    public string NomeCliente { get; set; }
    public string Endereco { get; set; }
    public decimal ValorTotal { get; set; } //Não pode ser alterado fora do pedido

    public void CalcularValorTotal()
    {
        if (Produtos != null)
        {
            foreach (Produto produto in Produtos)
            {
                ValorTotal += produto.Preco;
            }
        }
    }
}
