using System;

namespace Lab4
{
    interface IDecisionRandomizer
    {
        bool ShouldPerformAction();
    }

    class StdDecisionRandomizer : IDecisionRandomizer
    {
        private readonly double probability;
        private readonly Random random = new Random();

        public StdDecisionRandomizer(double prob)
        {
            probability = prob;
        }

        public bool ShouldPerformAction()
        {
            return random.NextDouble() <= probability;
        }
    }
}
