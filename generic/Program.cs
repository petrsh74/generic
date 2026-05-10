//#1
//class Program 
//{
//    public static T Max_num<T>(T a, T b, T c) where T : IComparable<T> 
//    {
//        T max = a;
//        if (b.CompareTo(max) > 0) max = b;
//        if (c.CompareTo(max) > 0) max = c;
//        return max;

//    }

//    static void Main() 
//    { 
//    int int_max= Max_num(1, 2, 3);
//        Console.WriteLine(int_max);
//    double double_max = Max_num(1.1, 2.1, 3.3);
//        Console.WriteLine(double_max);
//    string str_max = Max_num("aaa", "bbb", "c");
//        Console.WriteLine(str_max);



//    }

//}

// #3
//static class Extension
//{
//    public static bool Prime(this int n)
//    {
//        if (n < 2) return false;
//        for (int i = 2; i < n; i++)
//            if (n % i == 0) return false;
//        return true;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(5.Prime());
//        Console.WriteLine(10.Prime());
//    }
//}


//#4
//static class Extension
//{
//    public static int vavelstr(this string a)
//    {
//        int counter = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            char ch = Char.ToLower(a[i]); 
//            if ("aeiou".Contains(ch))     
//                counter++;
//        }
//        return counter;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string text = "aeioublsd";
//        Console.WriteLine($"Кількість голосних: {text.vavelstr()}");
//    }
//}


//#2
//public static T SumArray<T>(T[] arr)
//{
//    dynamic sum = default(T);
//    foreach (var item in arr)
//        sum += (dynamic)item;
//    return sum;
//}

//int[] ints = { 1, 2, 3 };
//Console.WriteLine(SumArray(ints));   

//double[] doubles = { 1.1, 2.2, 3.3 };
//Console.WriteLine(SumArray(doubles)); 


