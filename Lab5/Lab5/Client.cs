using System;

namespace Lab5
{
    class Client
    {
        public double NextRequestInterval { get; private set; } = 0;

        private readonly int minRequestTimeInterval, maxRequestTimeInterval;
        private readonly ITimeRandomizer nextRequestTimeRandomizer;

        public Client(int minReqTimeInt, int maxReqTimeInt,
            ITimeRandomizer timeRand = null)
        {
            minRequestTimeInterval = minReqTimeInt;
            maxRequestTimeInterval = maxReqTimeInt;
            nextRequestTimeRandomizer = timeRand ?? new StdTimeRandomizer();
        }

        public bool MoveOn(double dt)
        {
            NextRequestInterval -= dt;
            if (NextRequestInterval <= 0)
            {
                NextRequestInterval = nextRequestTimeRandomizer
                    .NextValue(minRequestTimeInterval, maxRequestTimeInterval);
                return true;
            }
            return false;
        }
    }
}
