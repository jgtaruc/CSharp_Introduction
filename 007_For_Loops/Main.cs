using System;

public class Loops {
    public static void Main() {
        var x = "This is like Java!!!";
        int n = 10;
        int i;
        for(i=0; i<n; i++) {
            Console.WriteLine(x);
        }

        Console.WriteLine("\n");

        i = 0;
        while(i<n) {
            Console.WriteLine(x);
            i++;
        }
    }
}