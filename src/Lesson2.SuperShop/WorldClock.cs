namespace Lesson2.SuperShop;

public class WorldClock : IClock
{
    public DateTime GetCurrentTime() => DateTime.UtcNow;
}