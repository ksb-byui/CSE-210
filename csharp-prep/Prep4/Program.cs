using System;

class Program
{
    static void Main(String[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers and then type the number 0 when finished.");

        while (true)
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
                break;
            numbers.Add(input);
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");       
    }
}