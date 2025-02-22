using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        Console.WriteLine("ArrayList Elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
