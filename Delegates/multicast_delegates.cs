// Multicast delegates 

class Programme {
    delegate void sendMessage();
    public static void Main(string[] args){
        sendMessage sendHello = new sendMessage(SayHello);
        sendMessage sendGoodBye = new sendMessage(SayGoodbye);
        // Multicast delegates 
        sendHello += sendGoodBye;
        sendHello();

    }

    public static void SayHello() {
        Console.WriteLine("Hello!");
    }

    public static void SayGoodbye() {
        Console.WriteLine("Goodbye!");
    }
}
