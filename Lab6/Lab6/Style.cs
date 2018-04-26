using System;

namespace Lab6
{
    class Style
    {
        public string Name { get; }
        public int MinTime { get; }

        public Style(string name, int avgTime)
        {
            Name = name;
            MinTime = avgTime;
        }
    }
}
