using System;

internal struct Vector
{
    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Length => Math.Sqrt(X * X + Y * Y);

    internal object CompareTo(Vector second)
    {
        return this.Length.CompareTo(second.Length);
    }

    public int X { get; }
    public int Y { get; }

    public static Vector Parse(string input)
    {
        if (input.Length == 0)
        {
            throw new ArgumentException("Incorrect vector");
        }
        string[] splInp = input.Split();
        
        if (splInp.Length != 2)
        {
            throw new ArgumentException("Incorrect vector");
        }
        if (int.TryParse(splInp[0], out int XX) && int.TryParse(splInp[1], out int YY)) {
            return new Vector(XX, YY);
        } else
        {
            throw new ArithmeticException("Incorrect vector");
        }
    }
}