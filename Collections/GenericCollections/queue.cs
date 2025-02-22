using System.Collections.Generic;
class Programe{
    public static void Main(string[] args){
       Queue<string> queue = new Queue<string>();

       // Adding elements to the queue
       queue.Enqueue("Apple");
       queue.Enqueue("Banana");
       queue.Enqueue("Cherry");

       // Displaying the queue
       Console.WriteLine("Queue elements:");
       foreach(string item in queue)
       {
        Console.WriteLine(item);
        }
    }
}
