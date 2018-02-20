using System;
using System.Collections.Generic;

public class Lists {
    public static void Main() {
        List<int> numbers = new List<int>();
        numbers.AddRange(new int[]{1,2,3});
        Console.WriteLine(numbers.Count);

        List<string> food = new List<string>();
        food.Add("rice");
        food.Add("steak");

        List<string> vegetables = new List<string>();
        vegetables.Add("tomato");
        vegetables.Add("Lettuce");

        food.AddRange(vegetables);
        Console.WriteLine(food.Count);

        List<int> primeNumbers = new List<int>(new int[]{2,3,5,7,11});
        Console.WriteLine(primeNumbers.Count);
    }
}