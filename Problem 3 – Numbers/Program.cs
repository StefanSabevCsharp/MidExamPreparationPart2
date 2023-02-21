using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_3___Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double avarage = numbers.Average();
            List<int> result = numbers.Where(x => x > avarage).OrderByDescending(x => x).Take(5).ToList();
            if (result.Any())
            {

            Console.WriteLine(string.Join(" ",result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
