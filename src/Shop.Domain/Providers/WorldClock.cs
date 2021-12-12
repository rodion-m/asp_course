namespace Shop.Domain.Providers;

public class WorldClock : IClock
{
    public DateTime GetCurrentTime() => DateTime.UtcNow;
}