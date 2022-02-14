using System;

internal class Singleton<T> where T: class, new()
{
    private static T instance = null;

    public Singleton() { }

        
    public static T Instance
    {
        get { 
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
        set => throw new NotSupportedException("This operation is not supported");
    }

}