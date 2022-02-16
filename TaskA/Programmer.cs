using System;

internal class Programmer
{
    public int Id { get; set; }

    public int GetAlmostRandomNumber()
    {
        return (int) Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);
    }

    public Programmer(int id)
    {
        Id = id;
    }

    public int GetIdDigitsSum()
    {
        int k = 0;
        int idd = Id;
        
        while (idd > 0)
        {
            k += idd % 10;
            idd /= 10;
        }

        return k;
    }
}