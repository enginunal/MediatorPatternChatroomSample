using System.Collections.Generic;

namespace MediatorChatroomSample
{
    public class ChatroomMediator : IChatroomMediator
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ChatroomMediator = this;
        }
        public void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }

}