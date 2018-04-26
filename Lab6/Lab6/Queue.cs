using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab6
{
    class Queue
    {
        private readonly Stylist[] _stylists;
        private readonly Queue<Client> _queue = new Queue<Client>();

        public int LengthLimit { get; }

        public Queue(Stylist[] stylists, int lengthLimit)
        {
            _stylists = stylists;
            LengthLimit = lengthLimit;
        }

        public bool Enqueue(Client client)
        {
            if (LengthLimit == -1 || _queue.Count < LengthLimit)
            {
                _queue.Enqueue(client);
                return true;
            }
            return false;
        }

        public void MoveOn()
        {
            var freeStylists =
                from s in _stylists
                where s.Active == false
                select s;

            var activeStylists = freeStylists as Stylist[] ?? freeStylists.ToArray();
            if (!activeStylists.Any())
            {
                return;
            }

            var waitingClients = new Queue<Client>();
            var isStylistActive = new bool[activeStylists.Length];
            while (isStylistActive.Any(x => x == false) && _queue.Count > 0)
            {
                if (_queue.Peek().PersonalStylist == null)
                {
                    for (int i = 0; i < activeStylists.Length; i++)
                    {
                        if (!isStylistActive[i])
                        {
                            isStylistActive[i] = true;
                            activeStylists[i].StartServing(_queue.Dequeue());
                            break;
                        }
                    }
                }
                else
                {
                    bool foundStylist = false;

                    for (int i = 0; i < activeStylists.Length && _queue.Count > 0; i++)
                    {
                        if (activeStylists[i] == _queue.Peek().PersonalStylist && !isStylistActive[i])
                        {
                            isStylistActive[i] = true;
                            activeStylists[i].StartServing(_queue.Dequeue());
                            foundStylist = true;
                        }
                    }

                    if (!foundStylist)
                    {
                        waitingClients.Enqueue(_queue.Dequeue());
                    }
                }
            }

            var tempQueue = new Queue<Client>();
            while (_queue.Count > 0)
            {
                tempQueue.Enqueue(_queue.Dequeue());
            }

            while (waitingClients.Count > 0)
            {
                _queue.Enqueue(waitingClients.Dequeue());
            }
            while (tempQueue.Count > 0)
            {
                _queue.Enqueue(tempQueue.Dequeue());
            }
        }
    }
}
