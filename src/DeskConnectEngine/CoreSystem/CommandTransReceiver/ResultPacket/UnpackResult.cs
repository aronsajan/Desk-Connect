using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.HelperClass;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket
{
    class UnpackResult
    {
        public byte[] ResultPacket
        {
            get;
            set;
        }

        public ResultPacketElement Unpack()
        {
            ResultPacketElement Packet = new ResultPacketElement();
            byte[] HeaderBytes = Helper.ExtractBytes(0, 7, ResultPacket);
            byte[] ResultBytes = Helper.ExtractBytes(8, ResultPacket.Length - 1, ResultPacket);
            MemoryStream Memory = new MemoryStream(ResultBytes);

            BinaryFormatter BinUnpacker = new BinaryFormatter();
            Packet.ActualResult = BinUnpacker.Deserialize(Memory) as IResult;
            Packet.Header = BitConverter.ToInt64(HeaderBytes, 0);
            return Packet;


        }
    }
}
