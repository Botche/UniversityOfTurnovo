namespace Exam
{
    using System;
    using System.Linq;

    class StartUp
    {
        private const int speedIntervals = 12;

        private const int formattingNumber = 2;

        static void Main()
        {
            double[] trainSpeedsIntervalsForFirstHour = InitializeArray();
            Console.WriteLine("=================================================================");
            double[] trainSpeedsIntervalsForSecondHour = InitializeArray();

            double highestAverageSpeedForFirstHour = FindHighestAverageSpeedIntervalsInFifteenMinutes(trainSpeedsIntervalsForFirstHour);
            double highestAverageSpeedForSecondHour = FindHighestAverageSpeedIntervalsInFifteenMinutes(trainSpeedsIntervalsForSecondHour);

            Console.WriteLine("=================================================================");
            Console.WriteLine($"For first hour average speed is {Math.Round(trainSpeedsIntervalsForFirstHour.Average(), formattingNumber)}");
            Console.WriteLine($"For second hour average speed is {Math.Round(trainSpeedsIntervalsForSecondHour.Average(), formattingNumber)}");

            Console.WriteLine("=================================================================");
            Console.WriteLine($"Highest average speed for 15 minutes is {Math.Round(Math.Max(highestAverageSpeedForFirstHour, highestAverageSpeedForSecondHour), formattingNumber)}");
        }

        private static double FindHighestAverageSpeed(double[] averageSpeedIntervalsInFifthteenMinutes)
        {
            double highestAverageSpeedInFifthteenMinutes = averageSpeedIntervalsInFifthteenMinutes.Max();

            return highestAverageSpeedInFifthteenMinutes;
        }

        private static double FindHighestAverageSpeedIntervalsInFifteenMinutes(double[] trainSpeedsIntervalsForFirstHour)
        {
            var averageSpeedIntervalInFifteenMinutes = new double[speedIntervals / 3];
            for (int speedIntervalIndex = 0; speedIntervalIndex < trainSpeedsIntervalsForFirstHour.Length; speedIntervalIndex += 3)
            {
                var averageSpeedInFifteenMinutes = trainSpeedsIntervalsForFirstHour[speedIntervalIndex]
                    + trainSpeedsIntervalsForFirstHour[speedIntervalIndex + 1]
                    + trainSpeedsIntervalsForFirstHour[speedIntervalIndex + 2];

                averageSpeedIntervalInFifteenMinutes[speedIntervalIndex / 3] = averageSpeedInFifteenMinutes / 3;
            }

            return FindHighestAverageSpeed(averageSpeedIntervalInFifteenMinutes);
        }

        private static double[] InitializeArray()
        {
            const int minSpeed = 0;
            const int maxSpeed = 700;

            var trainSpeedIntervals = new double[speedIntervals];

            var counterOfIntervals = 0;
            while (counterOfIntervals != speedIntervals)
            {
                Console.Write("Enter a train speed: ");
                var line = Console.ReadLine();

                if (double.TryParse(line, out double number) && number > minSpeed && number < maxSpeed)
                {
                    trainSpeedIntervals[counterOfIntervals] = number;
                    counterOfIntervals++;

                    continue;
                }

                Console.WriteLine("An entered speed wasn't correct!");
            }


            return trainSpeedIntervals;
        }
    }
}
