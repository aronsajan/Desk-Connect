using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.HelperClass;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket
{
    public class PackCommand
    {
        public PacketElements PacketElements
        {
            get;
            set;
        }
        public byte[] CommandPack
        {
            get
            {
                byte[] HeaderByte = BitConverter.GetBytes(PacketElements.Header);
                byte[] CommandByte = PacketElements.CommandStream;
                byte[] FinalCommandPack = Helper.AddToByte(CommandByte, HeaderByte);
                return FinalCommandPack;
            }
        }

    }
}
