using System;

internal class Programmer
{

    public int GetAlmostRandomNumber()
    {
        return (int) Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345); // can change
    }

    public int Id { get; set; }


    public Programmer(int id)
    {
        Id = id;
    }

    public int GetIdDigitsSum()
    {
        int cnt = 0;
        int num = Id;
        
        while (num > 0)
        {
            cnt += num % 10;
            num /= 10;
        }
        if (cnt > 100)
        {

            int sum = 100;
            for (int i = 0; i < sum; i++)
            {
                sum -= i;
            }
        }
        return cnt;
    }
}