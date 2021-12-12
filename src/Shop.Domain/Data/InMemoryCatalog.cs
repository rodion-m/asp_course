using Microsoft.Extensions.Logging;
using Shop.Domain.Models;

namespace Shop.Domain.Data;

public class InMemoryCatalog : ICatalog
{
    public IReadOnlyCollection<Product> GetAllProducts() => new[]
    {
        new Product("Чистый код", 500, "Роберт Мартин"),
        new Product("Внедрение зависимостей в C#", 1000, "Марк Симан"),
        new Product("Элегантные объекты", 5000, "Егор Бугаенко")
    };

    public Product GetProductById(int productId) => GetAllProducts().First();
}