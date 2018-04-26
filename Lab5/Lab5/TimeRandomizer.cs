using System;

namespace Lab5
{
    interface ITimeRandomizer
    {
        double NextValue(int minValue, int maxValue);
    }

    class StdTimeRandomizer : ITimeRandomizer
    {
        private readonly Random random = new Random();

        public double NextValue(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue) + random.NextDouble();
        }
    }
}
