using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkReceiver;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.Receiver
{
    public class ReceiveResult:ReceiveBase
    {
        public ResultPacketElement GetResultPacket()
        {
            NetworkReceive Receiver = new NetworkReceive(int.Parse(ConfigurationSettings.AppSettings["ResultPort"]));
            DataPack = Receiver.ReceiveData();
            UnpackResult Unpack = new UnpackResult();
            Unpack.ResultPacket = DataPack;
            return Unpack.Unpack();
        }
    }
}
