using System;

public class Functions {
    public static void Main(string[] args) {
        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);
        Console.WriteLine(divide(a, b));
    }

    static double divide(int a, int b) {
        return a/b;
    }
}