
using ratclient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratclient.Packets
{
    [Serializable ]
    public class StringMessagePacket : IPacket 
    {
        public string Message;

        public static StringMessagePacket Create(string message)
        {
            return new StringMessagePacket() { Message = message };
        }
    }
}
