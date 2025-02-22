using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        Hashtable table = new Hashtable();
        table.Add(1, "Apple");
        table.Add(2, "Banana");
        table.Add(3, "Cherry");

        Console.WriteLine("Hashtable Elements:");
        foreach (DictionaryEntry entry in table)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}
