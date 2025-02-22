# Generic Collections in C#

This document provides simple examples of common generic collections in C#. Click the links below to jump to each section:

- [List\<T\> Example](#listt-example)
- [Dictionary\<TKey, TValue\> Example](#dictionarytkey-tvalue-example)
- [Stack\<T\> Example](#stackt-example)
- [Queue\<T\> Example](#queuet-example)

---

## 🔗 Complete C# Code for All Examples

```csharp
using System;
using System.Collections.Generic;

class GenericCollectionsExample
{
    public static void Main()
    {
        // List<T> Example
        Console.WriteLine("📋 List<T> Example:");
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        Console.WriteLine("List Elements:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\n---------------------------\n");

        // Dictionary<TKey, TValue> Example
        Console.WriteLine("📚 Dictionary<TKey, TValue> Example:");
        Dictionary<int, string> employees = new Dictionary<int, string>
        {
            { 101, "Alice" },
            { 102, "Bob" },
            { 103, "Charlie" }
        };

        Console.WriteLine("Dictionary Elements:");
        foreach (var kvp in employees)
        {
            Console.WriteLine("ID: " + kvp.Key + ", Name: " + kvp.Value);
        }

        Console.WriteLine("\n---------------------------\n");

        // Stack<T> Example
        Console.WriteLine("🏗️ Stack<T> Example:");
        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);

        Console.WriteLine("Stack Elements (LIFO):");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n---------------------------\n");

        // Queue<T> Example
        Console.WriteLine("📬 Queue<T> Example:");
        Queue<string> tasks = new Queue<string>();
        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        tasks.Enqueue("Task 3");

        Console.WriteLine("Queue Elements (FIFO):");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }

        Console.WriteLine("\n---------------------------\n");
    }
}
