using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Api.Database.Context;

namespace Shop.Api.Database;

public static class SeedData
{
    private static readonly List<string> _produtos = ["Caneta", "Lápis", "Caderno",];

    private static readonly Dictionary<string, decimal> _precos = new ()
    {
        { "Caneta", 3 },
        { "Lápis", 2 },
        { "Caderno", 15 },
    };

    public static IHost Seed(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApiContext>();

        var id = 0;

        _produtos.ForEach(p => 
        {
            var preco = _precos.TryGetValue(p, out var value);
            var produto = new Produto
            {
                Nome = p,
                Preco = value,
            };

            context.Add(produto);
        });
        context.SaveChanges();
        return app;
    }
}
