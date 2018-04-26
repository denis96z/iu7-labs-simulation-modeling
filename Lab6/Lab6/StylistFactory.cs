using System;

namespace Lab6
{
    class StylistFactory : IFactory<Stylist>
    {
        private readonly ITimeRandomizer _maxDelayRandomizer;

        public int MinDelay { get; }
        public int MaxDelay { get; }
        public ITimeRandomizer DelayRandomizer { get; }

        public StylistFactory(int minDelay, int maxDelay,
            ITimeRandomizer maxDelayRandomizer = null,
            ITimeRandomizer delayRandomizer = null)
        {
            MinDelay = minDelay;
            MaxDelay = maxDelay;
            _maxDelayRandomizer = maxDelayRandomizer ?? new StdTimeRandomizer();
            DelayRandomizer = delayRandomizer ?? new StdTimeRandomizer();
        }

        public Stylist Create()
        {
            return new Stylist(_maxDelayRandomizer
                .NextInt(MinDelay, MaxDelay), DelayRandomizer);
        }
    }
}
