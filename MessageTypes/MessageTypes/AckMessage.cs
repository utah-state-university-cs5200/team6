using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MessageTypes
{
    public class AckMessage : Message
    {
        public short ID;
        public bool gORp;

        //
        public AckMessage(short ID, bool gORp)
        {
            MessageType = 5;
            this.ID = ID;
            this.gORp = gORp;
        }

        public override void DoMessageTask()
        {
            //Do Stuff
        }

        public override Byte[] Encode()
        {
            //TODO:
            //Encode MessageType
            //Encode ID
            //Encode gORp
            //Return byte[] message
            return null;
        }

        //For use in the Message Factory
        public static Message Decode(MemoryStream f, Byte[] items)
        {
            //TODO:
            //Read byte MessageType
            //Read short ID
            //Read byte gORp
            //return new Message(MessageType, ID, gORp)
            return null;
        }
    }
}
