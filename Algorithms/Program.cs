using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double sum = 0;
        List<double> numbers = new List<double>();

        Console.Write("n = ");
        int.TryParse(Console.ReadLine(), out int n);

        if (n == 0)
        {
            Console.WriteLine("No result.");
            return;
        }

        int i = 0;
        do
        {
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            sum += a;
            numbers.Add(a);
            i++;
        }
        while (i != n);

        double mean = sum / n;

        numbers.Sort();

        
        double median;
        if (n % 2 == 1)
        {
            median = numbers[n / 2];
        }
        else
        {
            median = (numbers[(n / 2) - 1] + numbers[n / 2]) / 2.0;
        }

        double min = numbers[0];
        double max = numbers[n - 1];

        Console.WriteLine($"Mean:   {mean:F2}");
        Console.WriteLine($"Median: {median:F2}");
        Console.WriteLine($"Min:    {min:F2}");
        Console.WriteLine($"Max:    {max:F2}");
    }
}
