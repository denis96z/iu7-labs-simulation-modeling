using System;

namespace Lab5
{
    class ServiceUnit
    {
        public bool Active { get; private set; } = false;
        public double? TimeLeft { get; private set; } = null;

        private readonly int minServiceTime, maxServiceTime;
        public int MinServiceTime { get { return minServiceTime; } }
        public int MaxServiceTime { get { return maxServiceTime; } }

        private readonly ITimeRandomizer timeRandomizer;

        public ServiceUnit(int minServTime, int maxServTime,
            ITimeRandomizer timeRand = null)
        {
            minServiceTime = minServTime;
            maxServiceTime = maxServTime;
            timeRandomizer = timeRand ?? new StdTimeRandomizer();
        }

        public virtual void StartServing()
        {
            Active = true;
            TimeLeft = timeRandomizer.NextValue(minServiceTime, maxServiceTime);
        }

        public virtual void ContinueServing(double dt)
        {
            if (Active)
            {
                TimeLeft -= dt;
                Active = TimeLeft > 0;
            }
        }

        public virtual void StopServing()
        {
            Active = false;
            TimeLeft = null;
        }
    }
}
