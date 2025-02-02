using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"Сума: {sum}");
    }
}
