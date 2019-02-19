using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket;
using DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkReceiver;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.Receiver
{
   public class ReceiveCommand:ReceiveBase
    {
       
        public PacketElements GetCommandPacket()
        {
            NetworkReceive Receiver = new NetworkReceive(int.Parse(ConfigurationSettings.AppSettings["CommandPort"]));
            DataPack = Receiver.ReceiveData();
            SenderIP = Receiver.SenderIP;
            UnpackCommand Unpack = new UnpackCommand();
            Unpack.CommandPacket = DataPack;
            return Unpack.Unpack();
        }
        public string SenderIP
        {
            get;
            set;
        }
    }
}
