using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer._Reflection._Exception.Models
{
    public class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine($"Message sent via SMS"); ;
        }
    }
}
