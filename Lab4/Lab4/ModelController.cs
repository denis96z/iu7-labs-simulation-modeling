using System;

namespace Lab4
{
    abstract class ModelController
    {
        protected readonly int MAX_QUEUE_LENGTH;

        protected readonly int numRequests;
        protected IDecisionRandomizer loopBackDecisionRandomizer;
        protected readonly ITimeGenerator recvTimeGenerator, handlingTimeGenerator;

        protected readonly double[] recvTime;

        protected bool requestIsBeingHandled;
        protected double handlingFinishTime;

        public double CurrentTime { get; protected set; }
        public int QueueLength { get; protected set; }
        public int MaxQueueLength { get; protected set; }

        public int NumSentRequests { get; protected set; }
        public int NumReceivedRequests { get; protected set; }
        public int NumDeclinedRequests { get; protected set; }
        public int NumHandledRequests { get; protected set; }
        public int NumLoopedBackRequests { get; protected set; }

        public ModelController(ITimeGenerator recvTimeGen,
            ITimeGenerator handlingTimeGen, int nReq, IDecisionRandomizer lbDecisionRand)
        {
            numRequests = nReq;
            recvTime = new double[numRequests];

            recvTimeGenerator = recvTimeGen;
            handlingTimeGenerator = handlingTimeGen;
            loopBackDecisionRandomizer = lbDecisionRand;

            MAX_QUEUE_LENGTH = nReq;
        }

        public void Initialize()
        {
            recvTime[0] = recvTimeGenerator.NextValue();
            for (int i = 1; i < numRequests; i++)
            {
                recvTime[i] = recvTime[i - 1] + recvTimeGenerator.NextValue();
            }

            requestIsBeingHandled = false;

            QueueLength = 0;
            MaxQueueLength = 0;
            CurrentTime = 0;

            NumSentRequests = 0;
            NumReceivedRequests = 0;
            NumDeclinedRequests = 0;
            NumHandledRequests = 0;
            NumLoopedBackRequests = 0;
        }

        public void MoveOn()
        {
            PassTime();
            MaxQueueLength = Math.Max(MaxQueueLength, QueueLength);

            if (requestIsBeingHandled)
            {
                if (handlingFinishTime <= CurrentTime)
                {
                    NumHandledRequests++;
                    if (loopBackDecisionRandomizer.ShouldPerformAction())
                    {
                        NumLoopedBackRequests++;
                        handlingFinishTime = CurrentTime + handlingTimeGenerator.NextValue();
                    }
                    else
                    {
                        requestIsBeingHandled = false;
                    }
                }
            }
            else if (QueueLength > 0)
            {
                QueueLength--;
                handlingFinishTime = CurrentTime + handlingTimeGenerator.NextValue();
                requestIsBeingHandled = true;
            }

            if (NumSentRequests < numRequests &&
                recvTime[NumSentRequests] <= CurrentTime)
            {
                NumSentRequests++;
                if (QueueLength <= MAX_QUEUE_LENGTH)
                {
                    NumReceivedRequests++;
                    QueueLength++;
                }
                else
                {
                    NumDeclinedRequests++;
                }
            }
        }

        protected abstract void PassTime();

        public bool Finished()
        {
            return NumSentRequests == numRequests &&
                NumHandledRequests == NumReceivedRequests + NumLoopedBackRequests;
        }
    }

    class TimeModelController : ModelController
    {
        public double TimeStep { get; private set; }

        public TimeModelController(ITimeGenerator recvTimeGen,
            ITimeGenerator handleTimeGen, int nReq,
            IDecisionRandomizer lbDecisionRand, double timeStep) :
            base(recvTimeGen, handleTimeGen, nReq, lbDecisionRand)
        {
            TimeStep = timeStep;
        }

        protected override void PassTime()
        {
            CurrentTime += TimeStep;
        }
    }

    class EventModelController : ModelController
    {
        private const double ERROR = 1e-7;

        public EventModelController(ITimeGenerator recvTimeGen,
            ITimeGenerator handleTimeGen, int nReq, IDecisionRandomizer lbDecisionRand) :
            base(recvTimeGen, handleTimeGen, nReq, lbDecisionRand) { }

        protected override void PassTime()
        {
            if (NumReceivedRequests == numRequests)
            {
                CurrentTime = handlingFinishTime + ERROR;
            }
            else
            {
                if (requestIsBeingHandled)
                {
                    CurrentTime = Math.Min(handlingFinishTime,
                        recvTime[NumSentRequests]) + ERROR;
                }
                else
                {
                    CurrentTime = recvTime[NumSentRequests] + ERROR;
                }
            }
        }
    }
}
