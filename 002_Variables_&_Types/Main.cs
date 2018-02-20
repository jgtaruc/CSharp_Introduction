using System;

public enum CarType {
    Subaru = 1,
    Mazda = 2,
    Ford = 3
}

public class VariablesAndTypes {
    public static void Main() {
        var productName = "TV";
        int productYear = 2012;
        float productPrice = 279.99f;

        Console.WriteLine("productName: " + productName);
        Console.WriteLine("productYear: " + productYear);
        Console.WriteLine("productPrice: " + productPrice);

        CarType mycar = CarType.Subaru;
        Console.WriteLine(mycar);
    }
}