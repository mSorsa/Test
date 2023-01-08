namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public interface IColleague
    {
        /// <summary>
        /// Send a message to the mediator.
        /// </summary>
        /// <param name="message"></param>
        void Receive(string message);
        
        /// <summary>
        /// Send a message from the colleague.
        /// </summary>
        /// <param name="message"></param>
        void Send(string message);
    }
}