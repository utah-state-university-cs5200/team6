using System;

namespace MessageTypes
{
    public abstract class Message
    {
        public short MessageType;

        // As it stands, what DoMessageTask will need to take in as a parameter is undetermined
        public abstract void DoMessageTask();

        // Each message type will have its own encoding based on protocol
        public abstract Byte[] Encode();

        // Cannot make an abstract static function
        // will put the static Decode in each individual message anyways
    }
}
