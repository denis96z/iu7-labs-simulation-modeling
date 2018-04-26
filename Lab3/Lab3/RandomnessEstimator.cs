using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IRandomnessEstimator
    {
        double ApplyToSequence(int[] sequence, int range);
    }

    /// <summary>
    /// Класс оценки случайности последовательности.
    /// </summary>
    class RandomnessEstimator : IRandomnessEstimator
    {
        public double ApplyToSequence(int[] sequence, int range)
        {
            int n = sequence.Length;

            int mid = Math.Min(range / 2, n / 2);
            double[] stepPercent = new double[mid];

            int[] count = new int[range];
            for (int i = 1; i <= mid; i++)
            {
                Array.Clear(count, 0, range);
                for (int row = 0; row < i; row++)
                {
                    for (int j = row + i; j < n; j += i)
                    {
                        count[Math.Abs(sequence[j] - sequence[j - i])]++;
                    }
                }

                double k = 1.0 / (n - i);
                stepPercent[i - 1] = Enumerable.Count(from c in count
                    where c > 0 select c) * k;
            }

            double[] stepWeight = new double[mid];

            double totalWeight = 1.0;
            for (int i = 0; i < mid; i++)
            {
                stepWeight[i] = totalWeight / mid;
                totalWeight -= stepWeight[i] * (i + 1);
                for (int j = 0; j < i; j++)
                {
                    stepWeight[j] += stepWeight[i];
                }
            }

            double result = 0.0;
            for (int i = 0; i < mid; i++)
            {
                result += stepPercent[i] * stepWeight[i];
            }

            return result;
        }
    }
}
