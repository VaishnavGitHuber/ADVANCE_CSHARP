// sorted List 
using System;
using System.Collections.Generic;

class Programe {
    public static void Main(string[] args){
        // creating the sorted list 
        SortedList<int, string> sortedlist = new SortedList<int, string>();

        // adding elements to the sorted list
        sortedlist.Add(19, "Vaishnav");
        sortedlist.Add(2, "Adithya");
        sortedlist.Add(30, "Suresh");

        // printing the values 
        foreach(KeyValuePair<int, string> kvp in sortedlist){
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
