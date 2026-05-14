//#2
using System;

class Program
{
    public static T SumArray<T>(T[] arr)
    {
        dynamic sum = default(T);
        foreach (var item in arr)
        {
            sum += (dynamic)item;
        }
        return sum;
    }

    static void Main()
    {
        int[] ints = { 1, 2, 3 };
        Console.WriteLine($"Сума інт: {SumArray(ints)}");

        double[] doubles = { 1.1, 2.2, 3.3 };
        Console.WriteLine($"Сума дабл: {SumArray(doubles)}");
    }
}