using System;

namespace Lab5
{
    class Operator : ServiceUnit
    {
        private readonly ProcessingSystem processingSystem;

        public ProcessingSystem ProcessingSystem { get { return processingSystem; } }

        public Operator(int minServTime, int maxServTime, ProcessingSystem procSys,
            ITimeRandomizer timeRand = null) : base(minServTime, maxServTime, timeRand)
        {
            processingSystem = procSys;
        }

        public override void ContinueServing(double dt)
        {
            bool wasActive = Active;
            base.ContinueServing(dt);
            if (wasActive && !Active)
            {
                processingSystem.EnqueueRequest();
            }
        }
    }
}
