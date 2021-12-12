namespace Lesson2.SuperShop;

public interface ICatalog
{
    IReadOnlyCollection<Product> GetProducts();
}