using System;
using System.Collections.Generic;

namespace Lab1
{
    interface IDistribution
    {
        List<(double, double)> DistributionFunctionRange(double x1, double x2, int n);
        List<(double, double)> DensityFunctionRange(double x1, double x2, int n);

        double DistributionFunction(double x);
        double DensityFunction(double x);
    }

    class NormalDistribution : IDistribution
    {
        private double mathExpectation = 0, dispersion = 1;
        private delegate double OneArgFun(double x);

        public NormalDistribution(double me, double d)
        {
            mathExpectation = me;
            dispersion = d;
        }

        public List<(double, double)> DistributionFunctionRange(double x1, double x2, int n)
        {
            return GetRange(DistributionFunction, x1, x2, n);
        }

        public List<(double, double)> DensityFunctionRange(double x1, double x2, int n)
        {
            return GetRange(DensityFunction, x1, x2, n);
        }

        public double DistributionFunction(double x)
        {
            double xn = (x - mathExpectation) / dispersion;
            return 0.5 * (1.0 + alglib.errorfunction(xn / Math.Sqrt(2.0)));
        }

        public double DensityFunction(double x)
        {
            return Math.Exp(-Math.Pow(x - mathExpectation, 2) / (2 * dispersion * dispersion)) /
                (dispersion * Math.Sqrt(Math.PI + Math.PI));
        }

        private List<(double, double)> GetRange(OneArgFun f, double x1, double x2, int n)
        {
            double h = (x2 - x1) / n;
            var list = new List<(double, double)>();
            for (double x = x1; x <= x2; x += h)
            {
                list.Add((x, f(x)));
            }
            return list;
        }
    }
}
