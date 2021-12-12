using Shop.Domain.Models;

namespace Shop.Domain.Data;

public interface ICatalog
{
    IReadOnlyCollection<Product> GetAllProducts();
    Product GetProductById(int productId);
}