using System;
using System.Collections.Generic;

public class Dictionaries {
    public static void Main() {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory["apple"] = 3;
        inventory["orange"] = 5;
        inventory["banana"] = 2;
        
        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);

        inventory.Remove("apple");
        if(!inventory.ContainsKey("apple")) {
            Console.WriteLine("apple is gone");
        }
    }
}