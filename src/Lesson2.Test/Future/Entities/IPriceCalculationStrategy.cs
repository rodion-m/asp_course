namespace Lesson2.Future.Entities;

public interface IPriceCalculationStrategy
{
    decimal Calculate(decimal price);
}