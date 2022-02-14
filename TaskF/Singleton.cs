using System;

internal class Singleton<T>
{
    private static T what;

    public Singleton(T value) => what = value;

        
    public static T Instance
    {
        get => what;
        set => throw new NotSupportedException("This operation is not supported");
    }

}