# Non-Generic Collections in C#

This document provides simple examples of common non-generic collections in C#. Click the links below to jump to each section:

- [ArrayList Example](#arraylist-example)
- [Hashtable Example](#hashtable-example)
- [Stack Example](#stack-example)
- [Queue Example](#queue-example)

---

## 🔗 Complete C# Code for All Examples

```csharp
using System;
using System.Collections;

class NonGenericCollectionsExample
{
    public static void Main()
    {
        // ArrayList Example
        Console.WriteLine("🔢 ArrayList Example:");
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        Console.WriteLine("ArrayList Elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n---------------------------\n");

        // Hashtable Example
        Console.WriteLine("🔑 Hashtable Example:");
        Hashtable table = new Hashtable();
        table.Add(1, "Apple");
        table.Add(2, "Banana");
        table.Add(3, "Cherry");

        Console.WriteLine("Hashtable Elements:");
        foreach (DictionaryEntry entry in table)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        Console.WriteLine("\n---------------------------\n");

        // Stack Example
        Console.WriteLine("🏗️ Stack Example:");
        Stack stack = new Stack();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine("Stack Elements (LIFO):");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n---------------------------\n");

        // Queue Example
        Console.WriteLine("📬 Queue Example:");
        Queue queue = new Queue();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Queue Elements (FIFO):");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n---------------------------\n");
    }
}
