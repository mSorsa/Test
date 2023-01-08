using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public class Colleague : IColleague
    {
        private readonly IMediator _mediator;
        public readonly int Id;
        
        public Colleague(IMediator mediator, int id = 0)
        {
            _mediator = mediator;
            Id = id;
            _mediator.AddColleague(this);
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        
        public void Receive(string message)
        {
            Console.WriteLine($"Colleague {this.Id} received message: \"{message}\".");
        }
    }
}
