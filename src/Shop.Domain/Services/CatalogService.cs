using Shop.Domain.Data;
using Shop.Domain.Models;
using Shop.Domain.Providers;

namespace Shop.Domain.Services;

public class CatalogService
{
    private readonly IClock _clock;
    private readonly ICatalog _catalog;
    
    public CatalogService(IClock clock, ICatalog catalog)
    {
        _clock = clock;
        _catalog = catalog;
    }
    




    public CatalogResult GetCatalog()
    {
        if (IsSaturdayOrSunday())
        {
            return new CatalogResult(_catalog.GetAllProducts().Select(
                it => it with { Price = it.Price * 1.5m }
                )
            );
        }

        return new CatalogResult(_catalog.GetAllProducts());
    }

    private bool IsSaturdayOrSunday() 
        => _clock.GetCurrentTime().DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

    public List<string> GetAuthors()
    {
        return _catalog.GetAllProducts().Select(it => it.Author).ToList();
    }
}