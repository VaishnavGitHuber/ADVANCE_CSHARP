using System.Collections.Generic;
class Programe{
    public static void Main(string[] args){
        Stack<string> stack = new Stack<string>();

        stack.Push("Hello");
        stack.Push("World");
        stack.Push("!");

        // printStack(stack);
        Console.WriteLine(stack.Pop()); // Output: "!"
        Console.WriteLine(stack.Pop()); // Output: "World"
        Console.WriteLine(stack.Pop()); // Output: "Hello"
    }
}
