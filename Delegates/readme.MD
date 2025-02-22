# Delegates in C#

This document explains how to use delegates in C#. Click the links below to jump to each section:

- [Anonymous Delegate Example](#anonymous-delegate-example)
- [Single-Cast Delegate Example](#single-cast-delegate-example)
- [Multicast Delegate Example](#multicast-delegate-example)

---

## 🔗 Complete C# Code for All Delegate Examples

```csharp
using System;

class DelegatesExample
{
    // Delegate Declarations
    delegate void SendMessage();
    delegate double AddNumbers(double x, double y);
    delegate int Calculator(int x, int y);

    public static void Main(string[] args)
    {
        // 1. Anonymous Delegate Example
        Console.WriteLine("🔍 Anonymous Delegate Example:");

        SendMessage message = delegate ()
        {
            Console.WriteLine("Hello World!");
        };

        AddNumbers add = delegate (double x, double y)
        {
            return x + y;
        };

        message();
        Console.WriteLine("Sum of 6 and 7: " + add(6, 7));

        Console.WriteLine("\n---------------------------\n");

        // 2. Single-Cast Delegate Example
        Console.WriteLine("➕ Single-Cast Delegate Example:");

        Calculator calAdd = new Calculator(AddNumbersMethod);
        Calculator calSub = new Calculator(SubNumbersMethod);

        Console.WriteLine("Addition of (9, 8): " + calAdd.Invoke(9, 8));
        Console.WriteLine("Subtraction of (9, 8): " + calSub.Invoke(9, 8));

        Console.WriteLine("\n---------------------------\n");

        // 3. Multicast Delegate Example
        Console.WriteLine("🔗 Multicast Delegate Example:");

        SendMessage sendHello = new SendMessage(SayHello);
        SendMessage sendGoodbye = new SendMessage(SayGoodbye);

        // Combining delegates
        sendHello += sendGoodbye;

        sendHello(); // Invokes both methods

        Console.WriteLine("\n---------------------------\n");
    }

    // Methods for Single-Cast Delegates
    public static int AddNumbersMethod(int x, int y)
    {
        return x + y;
    }

    public static int SubNumbersMethod(int x, int y)
    {
        return x - y;
    }

    // Methods for Multicast Delegates
    public static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}
