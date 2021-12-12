using System;
using Shop.Domain.Providers;

namespace Lesson2.Test;

public class FakeClock : IClock
{
    private readonly DateTime _dateTime;

    public FakeClock(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public DateTime GetCurrentTime() => _dateTime;
}