namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
            => _strategy.Execute();
    }
}
