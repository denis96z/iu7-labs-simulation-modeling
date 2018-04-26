using System;

namespace Lab6
{
    class ClientGenerator
    {
        public double NextArrivalInterval { get; private set; } = 0;

        private readonly int _minArrivalInterval, _maxArrivalInterval;
        private readonly IFactory<Client> _clientFactory;
        private readonly ITimeRandomizer _nextArrivalRandomizer;

        public ClientGenerator(int minArrivalInt, int maxArrivalInt,
            IFactory<Client> clientFactory, ITimeRandomizer nextArrivalRand = null)
        {
            _minArrivalInterval = minArrivalInt;
            _maxArrivalInterval = maxArrivalInt;
            _clientFactory = clientFactory;
            _nextArrivalRandomizer = nextArrivalRand ?? new StdTimeRandomizer();
        }

        public Client Generate(double dt)
        {
            NextArrivalInterval -= dt;
            if (NextArrivalInterval <= 0)
            {
                NextArrivalInterval = _nextArrivalRandomizer
                    .NextDouble(_minArrivalInterval, _maxArrivalInterval);
                return _clientFactory.Create();
            }
            return null;
        }
    }
}
