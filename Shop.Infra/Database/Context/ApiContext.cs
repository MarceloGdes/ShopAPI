using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entidades;

namespace Shop.Api.Database.Context;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<Produto> Products { get; set; }
    public DbSet<Pedido> Orders { get; set; }
}

