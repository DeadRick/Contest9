using System;

internal class Calendar
{
    public event Action<DateTime> EveryDayNotification;

    public void Simulate(DateTime startTime, DateTime endTime)
    {
        for (var i = startTime; i <= endTime; i = i.AddDays(1))
        {
            EveryDayNotification?.Invoke(i);
        }
    }
}