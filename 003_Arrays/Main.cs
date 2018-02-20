using System;

public class Arrays {
    public static void Main() {
        int[] nums = {1, 2, 3};
        int[] nums2 = new int[10];
        Console.WriteLine(nums2.Length);

        int[,] matrix = new int[2,2]{
            {1, 2}, 
            {3, 4}
        };
        Console.WriteLine(matrix[0,1]);

        string[] fruits = {"apple", "banana", "orange"};
        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[1]);
        Console.WriteLine(fruits[2]);
    }
}