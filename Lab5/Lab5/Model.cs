using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab5
{
    class Model
    {
        private Client client = new Client(minReqTimeInt: 8, maxReqTimeInt: 12);

        private readonly Operator[] operators;
        private readonly ProcessingSystem[] processingSystems =
        {
            new ProcessingSystem(minProcTime: 15, maxProcTime: 15),
            new ProcessingSystem(minProcTime: 30, maxProcTime: 30)
        };

        public double TimeStep { get; set; }
        public double CurrentTime { get; private set; }

        public bool Active
        {
            get
            {
                return operators.Any(o => o.Active) ||
                    processingSystems.Any(s => s.Active);
            }
        }


        public int NumHandledRequests { get; private set; }
        public int NumDeclinedRequests { get; private set; }

        public Model(double timeStep = 0.01)
        {
            TimeStep = timeStep;

            operators = new Operator[]
            {
                new Operator(minServTime: 15, maxServTime: 25, procSys: processingSystems[0]),
                new Operator(minServTime: 30, maxServTime: 50, procSys: processingSystems[0]),
                new Operator(minServTime: 20, maxServTime: 60, procSys: processingSystems[1])
            };
        }

        public void Restart()
        {
            CurrentTime = 0;
        }

        public void MoveOn()
        {
            CurrentTime += TimeStep;
            bool newRequestReceived = client.MoveOn(TimeStep);

            if (newRequestReceived)
            {
                var availableOperators =
                from o in operators
                where o.Active == false
                orderby o.ProcessingSystem.QueueLength, o.MinServiceTime
                select o;

                if (Enumerable.Count(availableOperators) == 0)
                {
                    NumDeclinedRequests++;
                }
                else
                {
                    availableOperators.First().StartServing();
                }
                    
            }

            foreach (var o in operators)
            {
                o.ContinueServing(TimeStep);
            }

            foreach (var s in processingSystems)
            {
                if (s.ContinueServing(TimeStep))
                {
                    NumHandledRequests++;
                }
            }
        }
    }
}
