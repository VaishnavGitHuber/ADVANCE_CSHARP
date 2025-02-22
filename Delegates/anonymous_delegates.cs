class Programme{
    delegate void SendMessage();
    delegate double AddNumbers(double x,double y);

    public static void Main(string[] args){

        SendMessage message = delegate(){
            Console.WriteLine("Hello World!");
        };

        AddNumbers add = delegate(double x,double y) {
            return x+y;
        };
        message();
        Console.WriteLine("Sum of 6,7: "  + add(6,7));
    }
}
// output: 
// Hello World!
// Sum of 6,7: 13
