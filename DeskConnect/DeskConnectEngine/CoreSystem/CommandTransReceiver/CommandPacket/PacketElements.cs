using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket
{
   public class PacketElements
    {
        
        private byte[] _commandStream;
        public byte[] CommandStream
        {
            get
            {
                BinaryFormatter BinFormat = new BinaryFormatter();
                MemoryStream Memory = new MemoryStream();
                BinFormat.Serialize(Memory, ActualCommand);
                _commandStream = Memory.GetBuffer();
                return _commandStream;
            }
        }
        public IExecute ActualCommand
        {
            get;
            set;
        }
        public long Header
        {
            get;
            set;
        }
    }
}
