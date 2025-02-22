// 1. Delegate 

class Programe {
    delegate int Calculator(int x, int y);

    public static void Main(string[] args){
        Calculator calAdd = new Calculator(AddNumbers);
        Calculator calSub= new Calculator(SubNumbers);
        Console.WriteLine("Addition of (9,8) = " + calAdd.Invoke(8,9));
        Console.WriteLine("Subtraction of (9,8) = " + calSub(9,8));
        // Console.WriteLine("Addition of (9,8) = " + AddNumbers(8,9));
        // Console.WriteLine("Subtraction of (9,8) = " + SubNumbers(9,8));
    }

    public static int AddNumbers(int x, int y) {
        return x + y;
    }
    public static int SubNumbers(int x, int y){
        return x - y;
    }
}
