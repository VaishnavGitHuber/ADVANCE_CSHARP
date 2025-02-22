## Delegates
- delegates are the  type safe function pointers 
### 1. Multicast delegates: can be used to invoke more than one methods 
### 2. Anonymous delegates: can be define a mthod without name(Anonymous method)

```
/* 
class Delegate {
    delegate void Calculator(double x, double y);
    delegate void Greeting(string name);
    public static void Main(string[] args){
        Calculator cal = new Calculator(Delegate.Addition);
        cal += Delegate.Subtraction;
        cal += Delegate.Division;
        cal += Delegate.Multiplication;
        cal.Invoke(10, 5);

        Console.WriteLine("\nAnonymous function call");

        // ana=onymous function 
        Greeting greet = delegate(string name) {
            Console.WriteLine("Hello " + name);
        };
    
        greet("John");
    }

    public static void Addition(double x, double y){
        double AddResult = x + y;
        Console.WriteLine("Addition: {0}", AddResult);
    }
    public static void Subtraction(double x, double y){
        double SubResult = x - y;
        Console.WriteLine("Subtraction: {0}", SubResult);
    }
    public static void Division(double x, double y){
        double SubResult = x / y;
        Console.WriteLine("Division: {0}", SubResult);
    }
    public static void Multiplication(double x, double y){
        double SubResult = x * y;
        Console.WriteLine("Multiplication: {0}", SubResult);
    }
    
}


```
