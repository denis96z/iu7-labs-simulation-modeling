using System;

namespace Lab6
{
    class Stylist
    {
        public bool Active { get; private set; } = false;
        public double? TimeLeft { get; private set; } = null;

        private int MaxDelay { get; }
        private readonly ITimeRandomizer _timeRandomizer;

        public Stylist(int maxDelay, ITimeRandomizer timeRand = null)
        {
            MaxDelay = maxDelay;
            _timeRandomizer = timeRand ?? new StdTimeRandomizer();
        }

        public void StartServing(Client client)
        {
            Active = true;
            int minTime = client.Style.MinTime;
            TimeLeft = _timeRandomizer.NextDouble(minTime, minTime + MaxDelay);
        }

        public bool ContinueServing(double dT)
        {
            if (Active)
            {
                TimeLeft -= dT;
                if (TimeLeft <= 0)
                {
                    Active = false;
                    TimeLeft = null;
                }
            }
            return Active;
        }
    }
}
