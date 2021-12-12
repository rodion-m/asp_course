namespace Shop.Domain.Providers;

public interface IClock
{
    DateTime GetCurrentTime();
}