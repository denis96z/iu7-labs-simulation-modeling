using System;

namespace Lab6
{
    class StyleFactory : IFactory<Style>
    {
        private readonly ITimeRandomizer _timeRandomizer;

        public int MinTime { get; }
        public int MaxTime { get; }

        public StyleFactory(int minTime, int maxTime,
            ITimeRandomizer timeRandomizer = null)
        {
            MinTime = minTime;
            MaxTime = maxTime;
            _timeRandomizer = timeRandomizer ?? new StdTimeRandomizer();
        }

        public Style Create()
        {
            return new Style(null, _timeRandomizer.NextInt(MinTime, MaxTime));
        }
    }
}
