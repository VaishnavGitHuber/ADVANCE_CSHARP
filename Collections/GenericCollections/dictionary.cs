// collectios 
using System.Collections.Generic;
class Programe {
    public static void Main(string[] args){
        // Dictionary 
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(101, "Apple");
        dict.Add(102, "Banana");
        dict.Add(103, "Cherry");

        foreach(KeyValuePair<int, string> keyValuePair in dict){
            Console.WriteLine(keyValuePair.Key +" " + keyValuePair.Value);
        }
            
        }
}
