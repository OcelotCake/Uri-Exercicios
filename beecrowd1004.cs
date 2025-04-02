using System;

class Program
{
    static void Main()
    {
        // Read two integer values
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Calculate the sum and store it in the variable SOMA
        int PROD = A * B;

        // Print the result in the required format
        Console.WriteLine($"PROD = {PROD}");
    }

}