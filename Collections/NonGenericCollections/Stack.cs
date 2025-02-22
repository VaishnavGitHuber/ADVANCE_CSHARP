using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine("Stack Elements (LIFO):");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

