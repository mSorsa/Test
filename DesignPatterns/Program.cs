using DesignPatterns.BehavioralPatterns.MediatorPattern;
using DesignPatterns.BehavioralPatterns.StrategyPattern;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strategy Pattern
            Console.WriteLine("Strategy Pattern:\n");

            // Create concrete strategies
            var contextA = new Context(new ConcreteStrategyA());
            var contextB = new Context(new ConcreteStrategyB());

            // Execute strategies
            contextA.ExecuteStrategy();
            contextB.ExecuteStrategy();

            Console.WriteLine("\nPress any key to show Mediator Pattern");
            #endregion

            Console.ReadKey();

            #region Mediator Pattern
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\nMediator Pattern:\n");

            // Create mediator
            int numberOfColleagues = 0;
            var mediator = new ConcreteMediator();

            // Create colleagues
            var colleague1 = new Colleague(mediator, numberOfColleagues++);
            var colleague2 = new Colleague(mediator, numberOfColleagues++);
            var colleague3 = new Colleague(mediator, numberOfColleagues++);
            var colleague4 = new Colleague(mediator, numberOfColleagues++);

            // Send message
            colleague1.Send("Hello");

            // Add new colleague and send message again.
            var colleague5 = new Colleague(mediator, numberOfColleagues++);
            colleague1.Send("Hello again");

            // Add new colleague and send message from different colleague.
            var colleague6 = new Colleague(mediator, numberOfColleagues++);
            colleague2.Send("Hi");
            #endregion

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}