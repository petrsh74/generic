//#4
static class Extension
{
    public static int vavelstr(this string a)
    {
        int counter = 0;
        for (int i = 0; i < a.Length; i++)
        {
            char ch = Char.ToLower(a[i]);
            if ("aeiou".Contains(ch))
                counter++;
        }
        return counter;
    }
}

class Program
{
    static void Main()
    {
        string text = "aeioublsd";
        Console.WriteLine($"Кількість голосних: {text.vavelstr()}");
    }
}