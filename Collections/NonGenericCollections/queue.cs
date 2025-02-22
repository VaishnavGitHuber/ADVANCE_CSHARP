using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Queue Elements (FIFO):");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
