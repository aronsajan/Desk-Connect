using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.HelperClass;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket
{
    class UnpackCommand
    {
        public byte[] CommandPacket
        {
            get;
            set;
        }

        public PacketElements Unpack()
        {
            PacketElements Packet = new PacketElements(); 
            byte[] HeaderBytes = Helper.ExtractBytes(0, 7, CommandPacket);
            byte[] CommandBytes = Helper.ExtractBytes(8, CommandPacket.Length-1, CommandPacket);
            MemoryStream Memory = new MemoryStream(CommandBytes);
            
            BinaryFormatter BinUnpacker = new BinaryFormatter();
            Packet.ActualCommand = BinUnpacker.Deserialize(Memory) as IExecute;
            Packet.Header = BitConverter.ToInt64(HeaderBytes, 0);
            return Packet;

            
        }
     

    }


}
