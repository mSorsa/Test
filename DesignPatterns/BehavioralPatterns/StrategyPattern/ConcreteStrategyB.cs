namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing algorithm or behavior B");
        }
    }
}
