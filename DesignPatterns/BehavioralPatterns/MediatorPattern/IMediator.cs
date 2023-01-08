namespace DesignPatterns.BehavioralPatterns.MediatorPattern
{
    public interface IMediator
    {
        /// <summary>
        /// Send a message to all colleagues except the sender.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        void Send(string message, Colleague colleague);

        /// <summary>
        /// Add a colleague to the collection.
        /// </summary>
        /// <param name="colleague"></param>
        void AddColleague(Colleague colleague);
    }
}