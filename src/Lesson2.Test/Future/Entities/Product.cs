using System;

namespace Lesson2.Future.Entities;

public record Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        _price = price;
    }

    public string Name { get; }
    private readonly decimal _price;

    public decimal GetPrice(IPriceCalculationStrategy _strategy)
    {
        ArgumentNullException.ThrowIfNull(_strategy);
        return _strategy.Calculate(_price);
    }
}