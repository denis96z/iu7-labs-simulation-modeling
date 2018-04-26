using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    interface IDecisionRandomizer
    {
        bool Decide();
    }

    class StdDecisionRandomizer : IDecisionRandomizer
    {
        private readonly double _probability;
        private readonly Random _random = new Random();

        public StdDecisionRandomizer(double prob)
        {
            _probability = prob;
        }

        public bool Decide()
        {
            return _random.NextDouble() <= _probability;
        }
    }
}
