using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public Class1() { }
    static void Main(string[] args)
    {
        int total = 0;
        for (int x = 0; x < 1000; x++)
        {
            if (x % 3 == 0 || x % 5 == 0)
            {
                total += x;
            }
        }
        Console.WriteLine(total);
    }
}
