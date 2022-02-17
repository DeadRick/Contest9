using System;

internal class Hipster
{
    public int departureDay;
    public int arrivalDay;

    public int PostsRead { get; private set; }

    public Hipster(int departureDay, int arrivalDay)
    {
        this.departureDay = departureDay;
        this.arrivalDay = arrivalDay;
    }
    
    public void PostRead(DateTime time)
    {
        if (!(time.Day <= arrivalDay && time.Day >= departureDay))
        {
            PostsRead += 1;
        }
    }

    public void Subscribe(Blogger blogger)
    {
        blogger.Notify += PostRead;
    }
}