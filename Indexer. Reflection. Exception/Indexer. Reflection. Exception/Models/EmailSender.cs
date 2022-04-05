using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer._Reflection._Exception.Models
{
    public class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine($"Message send via Email");
        }
    }
}
