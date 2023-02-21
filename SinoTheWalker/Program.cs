using System;
using System.Linq;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hourLeaving = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine());
            int timeForSteps = int.Parse(Console.ReadLine());

            int hours = hourLeaving[0];
            int minutes = hourLeaving[1];
            int seconds = hourLeaving[2];
            int secondsStepTime = steps * timeForSteps;

            seconds += secondsStepTime;
            bool finished = true;
            while (finished)
            {
                if (minutes >= 60 || seconds >= 60)
                {

                    if (seconds >= 60)
                    {
                        minutes++;
                        seconds -= 60;
                    }
                    if (minutes >= 60)
                    {
                        hours++;
                        minutes -= 60;
                    }
                    if (hours >= 24)
                    {
                        hours = 0;
                    }
                    continue;
                }

                finished = false;

            }
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");









            //while (true)
            //{
            //    if (newMinutes < 60)
            //    {
            //        break;
            //    }
            //    if (newMinutes >= 60)
            //    {
            //        newHours++;
            //        newMinutes -= 60;
            //    }

            //}

        }
    }
}
