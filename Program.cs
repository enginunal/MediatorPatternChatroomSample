using System;

namespace MediatorChatroomSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatroomMediator chatroom = new ChatroomMediator();

            Participant Jale = new Participant("Jale");
            Participant Engin = new Participant("Engin");
            Participant Ali = new Participant("Ali");
            
            chatroom.Register(Jale);
            chatroom.Register(Engin);
            chatroom.Register(Ali);

            Jale.Send("Engin", "Merhaba.");
            Engin.Send("Jale", "Merhaba nasıl gidiyor..");
            Ali.Send("Jale", "Düzeltmeleri yaptım");
            Jale.Send("Ali", "Tamamdır teşekkürler.");
            
        }
    }
}
