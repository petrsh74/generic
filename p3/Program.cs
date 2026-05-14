// #3
static class Extension
{
    public static bool Prime(this int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++)
            if (n % i == 0) return false;
        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(5.Prime());
        Console.WriteLine(10.Prime());
    }
}