using System;

class Program
{
    static void Main()
    {
        int val;   // do not initial value
        outMethod(out val);
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void outMethod(out int i)
    {
        i = 20;
        i = i + 1;
    }
}

