using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        private readonly List<Colleague> _colleagues = new List<Colleague>();

        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
            Console.WriteLine($"Colleague {colleague.Id} added");
        }

        public void Send(string message, Colleague sender)
        {
            Console.WriteLine($"Colleague {sender.Id} sent message: \"{message}\" to {_colleagues.Count - 1} colleagues.");
            
            foreach (var c in _colleagues)
            {
                if (c != sender)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
