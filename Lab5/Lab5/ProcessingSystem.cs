using System;

namespace Lab5
{
    class ProcessingSystem
    {
        public bool Active { get; private set; } = false;

        public int QueueLength { get; private set; } = 0;
        private readonly ServiceUnit computer;

        public ProcessingSystem(int minProcTime, int maxProcTime)
        {
            computer = new ServiceUnit(minProcTime, maxProcTime);
        }

        public void EnqueueRequest()
        {
            Active = true;
            if (computer.Active)
            {
                QueueLength++;
            }
            else
            {
                computer.StartServing();
            }
        }

        public bool ContinueServing(double dt)
        {
            if (computer.Active)
            {
                computer.ContinueServing(dt);
                if (!computer.Active)
                {
                    return true;
                }
            }
            else if (QueueLength > 0)
            {
                computer.StartServing();
            }
            else
            {
                Active = false;
            }
            return false;
        }

        public void StopServing()
        {
            Active = false;
            computer.StopServing();
        }
    }
}
