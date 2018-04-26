using System;

namespace Lab6
{
    interface ITimeRandomizer
    {
        int NextInt(int minValue, int maxValue);
        double NextDouble(int minValue, int maxValue);
    }

    class StdTimeRandomizer : ITimeRandomizer
    {
        private readonly Random _random = new Random();

        public int NextInt(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
        }

        public double NextDouble(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue) + _random.NextDouble();
        }
    }
}
