using System;

namespace Lab4
{
    interface ITimeGenerator
    {
        double NextValue();
    }

    interface ITimeRandomizer : ITimeGenerator { }

    class GaussTimeRandomizer : ITimeRandomizer
    {
        private readonly double mathExp, disp;
        private readonly Random random = new Random();

        public GaussTimeRandomizer(double m, double d)
        {
            mathExp = m;
            disp = d;
        }

        public double NextValue()
        {
            double s = 0;
            for (int i = 0; i < 12; i++)
            {
                s += random.NextDouble();
            }

            double x = s - 6;
            x = Math.Abs(mathExp + x * Math.Sqrt(disp));

            return x;
        }
    }
}
