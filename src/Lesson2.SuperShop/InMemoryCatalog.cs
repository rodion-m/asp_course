namespace Lesson2.SuperShop;

public class InMemoryCatalog : ICatalog
{
    private readonly IClock _clock;

    public InMemoryCatalog(IClock clock)
    {
        if (clock == null) throw new ArgumentNullException(nameof(clock)); //Fail Fast
        _clock = clock;
    }
    
    private readonly IReadOnlyCollection<Product> _products = new[]
    {
        new Product("Роберт Мартин: Чистый код", 500),
        new Product("Марк Симан: Внедрение зависимостей в C#", 1000),
        new Product("Егор Бугаенко: Элегантные объекты", 5000)
    };

    public IReadOnlyCollection<Product> GetProducts()
    {
        if (IsSaturdayOrSunday())
        {
            return _products
                .Select(it => it with {Price = it.Price * 1.5m})
                .ToList();
        }

        return _products;
    }
    
    private bool IsSaturdayOrSunday() 
        => _clock.GetCurrentTime().DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
}