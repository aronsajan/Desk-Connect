using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.HelperClass;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket
{
    public class PackResult
    {
        public ResultPacketElement ResultPacketElements
        {
            get;
            set;
        }
        public byte[] ResultPack
        {
            get
            {
                byte[] HeaderByte = BitConverter.GetBytes(ResultPacketElements.Header);
                byte[] ResultByte = ResultPacketElements.ResultStream;
                byte[] FinalResultPack = Helper.AddToByte(ResultByte, HeaderByte);
                return FinalResultPack;
            }
        }
    }
}
