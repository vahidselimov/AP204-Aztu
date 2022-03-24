using System;
using System.Collections.Generic;
using System.Text;

namespace _24._03._22
{
    internal class SmsSender : MessageSender
    {
        public override void messagesender()
        {
            Console.WriteLine("SMS ile mesaj gonderilmelidir...");
        }
    }
}
