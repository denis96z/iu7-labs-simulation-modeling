using System;

namespace Lab6
{
    static class Constants
    {
        public const double TimeInterval = 0.01;
        public const double SimulationTime = 480;

        public const int QueueLengthLimit = -1;

        public const double ClientHasStylistProbability = 0.1;

        public const int MinClientArrivalTime = 5;
        public const int MaxClientArrivalTime = 20;

        public const int MinStyleTime = 10;
        public const int MaxStyleTime = 40;

        public const int MinStylistDelay = 0;
        public const int MaxStylistDelay = 10;
    }
}
