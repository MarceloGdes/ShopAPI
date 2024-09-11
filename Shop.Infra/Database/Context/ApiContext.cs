using Microsoft.EntityFrameworkCore;

namespace Shop.Api.Database.Context;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<Produto> Products { get; set; }
}

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
