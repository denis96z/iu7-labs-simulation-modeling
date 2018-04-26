using System;

namespace Lab6
{
    class Model
    {
        public double TimeInterval { get; set; } = Constants.TimeInterval;

        public int QueueLengthLimit { get; set; } = Constants.QueueLengthLimit;

        public double ClientHasStylistProbability { get; set; } =
            Constants.ClientHasStylistProbability;

        public int MinClientArrivalTime { get; set; } = Constants.MinClientArrivalTime;
        public int MaxClientArrivalTime { get; set; } = Constants.MaxClientArrivalTime;

        public int MinStyleTime { get; set; } = Constants.MinStyleTime;
        public int MaxStyleTime { get; set; } = Constants.MaxStyleTime;

        public int MinStylistDelay { get; set; } = Constants.MinStylistDelay;
        public int MaxStylistDelay { get; set; } = Constants.MaxStylistDelay;

        public double CurrentTime { get; private set; } = 0;
        public int ClientsArrived { get; private set; } = 0;
        public int ClientsDeclined { get; private set; } = 0;
        public int ClientsServed { get; private set; } = 0;

        private Style[] _styles = null;
        private Stylist[] _stylists = null;

        private ClientGenerator _clientGenerator = null;
        private Queue _queue = null;

        public void Initialize(int numStyles, int numStylists)
        {
            CurrentTime = 0;
            ClientsArrived = 0;
            ClientsDeclined = 0;
            ClientsServed = 0;

            var styleFactory = new StyleFactory(MinStyleTime, MaxStyleTime);
            _styles = new Style[numStyles];
            for (int i = 0; i < numStyles; i++)
            {
                _styles[i] = styleFactory.Create();
            }

            var stylistFactory = new StylistFactory(MinStylistDelay, MaxStylistDelay);
            _stylists = new Stylist[numStylists];
            for (int i = 0; i < numStylists; i++)
            {
                _stylists[i] = stylistFactory.Create();
            }

            var clientHasStylistRand = new StdDecisionRandomizer(ClientHasStylistProbability);
            var clientFactory = new ClientFactory(_styles, _stylists, clientHasStylistRand);
            _clientGenerator = new ClientGenerator(MinClientArrivalTime,
                MaxClientArrivalTime, clientFactory);

            _queue = new Queue(_stylists, QueueLengthLimit);
        }

        public void Simulate(double duration)
        {
            while (CurrentTime < duration)
            {
                Trace();
            }
        }

        public void Trace()
        {
            CurrentTime += TimeInterval;

            var newClient = _clientGenerator.Generate(TimeInterval);
            if (newClient != null)
            {
                ClientsArrived++;

                if (!_queue.Enqueue(newClient))
                {
                    ClientsDeclined++;
                }
            }

            _queue.MoveOn();
            foreach (var stylist in _stylists)
            {
                var wasActive = stylist.Active;
                if (!stylist.ContinueServing(TimeInterval) && wasActive)
                {
                    ClientsServed++;
                }
            }
        }
    }
}
