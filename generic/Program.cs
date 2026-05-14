//#1
class Program
{
    public static T Max_num<T>(T a, T b, T c) where T : IComparable<T>
    {
        T max = a;
        if (b.CompareTo(max) > 0) max = b;
        if (c.CompareTo(max) > 0) max = c;
        return max;

    }

    static void Main()
    {
        int int_max = Max_num(1, 2, 3);
        Console.WriteLine(int_max);
        double double_max = Max_num(1.1, 2.1, 3.3);
        Console.WriteLine(double_max);
        string str_max = Max_num("aaa", "bbb", "c");
        Console.WriteLine(str_max);
    }
}









