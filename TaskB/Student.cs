using System;

internal struct Student
{
    public Student(int id, int height, int math, int english, int PE)
    {
        Id = id;
        Height = height;
        Math = math;
        English = english;
        this.PE = PE;
        cnt++;
    }
    static int cnt = 0;
    public int Id { get; }
    public int Height { get; }
    public int Math { get; }
    public int English { get; }
    public int PE { get; }

    internal static Student Parse(string v)
    {
        string[] splV = v.Split();
        string idd = splV[0];
        string heightt = splV[1];
        string mathh = splV[2];
        string englishh = splV[3];
        string PEE = splV[4];

        return (new Student(int.Parse(idd), int.Parse(heightt), int.Parse(mathh), int.Parse(englishh), int.Parse(PEE)));
    }

    internal int CompareTo(Student bestInMath)
    {
        //Console.WriteLine("count = " + cnt);
        cnt--;
        if (cnt >= 0)
        {
            if (this.Math == bestInMath.Math)
            {
                return this.English.CompareTo(bestInMath.English);
            }
            return this.Math.CompareTo(bestInMath.Math);
        }
        else
        {
            if (this.PE == bestInMath.PE)
            {
                return this.Height.CompareTo(bestInMath.Height);
            }
            return this.PE.CompareTo(bestInMath.PE);
        }
    }

    public override string ToString()
    {
        return Id.ToString();
    }
}