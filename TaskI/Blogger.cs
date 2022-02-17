using System;

internal class Blogger
{
    private DayOfWeek postDay;
    public event Action<DateTime> Notify;

    public Blogger(DayOfWeek postDay)
    {
        this.postDay = postDay;
    }

    public void MakePost(DateTime date)
    {
        if (date.DayOfWeek == postDay)
        {
            Notify?.Invoke(date);
        }
    }
}