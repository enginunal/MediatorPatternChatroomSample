using System;

namespace MediatorChatroomSample
{
    public class Participant
    {
        public ChatroomMediator ChatroomMediator { get; set; }
        public string Name { get; }
        
        public Participant(string name)
        {
            Name = name;
        }        
        public void Send(string to, string message)
        {
            ChatroomMediator.Send(Name, to, message);
        }
        public void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }

}