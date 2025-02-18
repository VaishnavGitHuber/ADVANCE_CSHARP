# ADVANCE_CSHARP
Topics 
--

1. [Delegates](#1-delegates)


## 1. Delegates
```
class programme {
    delegate int ModifyNumber(int x);
    public static void Main(string[] args) {
        ModifyNumber del1 = new ModifyNumber(Add10);
        ModifyNumber del2 = new ModifyNumber(Mul10);
        Console.WriteLine("Add 10 to 10: " + del1(10)); // 10 + 10
        Console.WriteLine("Mul 10 to 10: " + del2(10)); // 10 * 10
    }

    static int Add10(int x){
        return x + 10;
    }

    static int Mul10(int x) {
        return x * 10;
    }
}
```
