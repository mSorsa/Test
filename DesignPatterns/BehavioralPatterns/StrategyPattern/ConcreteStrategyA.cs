namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing algorithm or behavior A");
        }
    }
}
