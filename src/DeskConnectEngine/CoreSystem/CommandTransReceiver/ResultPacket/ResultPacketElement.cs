using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket
{
   public class ResultPacketElement
    {
        private byte[] _resultStream;
        public byte[] ResultStream
        {
            get
            {
                BinaryFormatter BinFormat = new BinaryFormatter();
                MemoryStream Memory = new MemoryStream();
                BinFormat.Serialize(Memory, ActualResult);
                _resultStream = Memory.GetBuffer();
                return _resultStream;
            }
        }
        public IResult ActualResult
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
