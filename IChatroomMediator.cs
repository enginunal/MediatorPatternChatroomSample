namespace MediatorChatroomSample
{
    public interface IChatroomMediator
    {
        public void Register(Participant participant);
        public void Send(string from, string to, string message);
    }
}