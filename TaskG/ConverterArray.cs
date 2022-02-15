using System;
using System.Collections;
using System.Collections.Generic;

internal class ConverterArray<TV, TU> : IConverterArray<TV, TU>, IEnumerable
{
    public TU GetAt(int index)
    {
        return conv.Convert(arr[index]);
    }

    public void SetAt(int index, TV tv)
    {
        arr[index] = tv;
        arr2[index] = conv.Convert(tv);
    }

    public IEnumerator GetEnumerator()
    {
        return arr2.GetEnumerator();
    }

    public TV[] arr;
    public IConverter<TV, TU> conv;
    public TU[] arr2;
    public int Length;
    public ConverterArray(int length, IConverter<TV, TU> converter)
    {
        conv = converter;
        arr2 = new TU[length];
        arr = new TV[length];
        Length = length;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}