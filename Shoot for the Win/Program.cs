using System;
using System.Linq;
namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command;
            int targetsShot = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int indexShot = int.Parse(command);

                if (indexShot < 0 || indexShot >= numbers.Length)
                {
                    continue;
                }
                if (numbers[indexShot] == -1)
                {
                    continue;
                }
                int currentNumber = numbers[indexShot];
                numbers[indexShot] = -1;
                targetsShot++;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == -1)
                    {
                        continue;
                    }
                    if (numbers[i] > currentNumber)
                    {
                        numbers[i] -= currentNumber;
                    }
                    else if (numbers[i] <= currentNumber)
                    {
                        numbers[i] += currentNumber;
                    }
                }

            }
            Console.WriteLine($"Shot targets: {targetsShot} -> { string.Join(" ",numbers)}");
        }
    }
}
