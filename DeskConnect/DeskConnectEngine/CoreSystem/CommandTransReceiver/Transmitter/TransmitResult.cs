using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkSender;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter
{
    public class TransmitResult:TransmitBase
    {
        public void SendResult()
        {
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = RemoteSystemName;
            NetworkSend Sender = new NetworkSend(int.Parse(ConfigurationSettings.AppSettings["ResultPort"]));
            Sender.NetworkParameters = NetParams;
            Sender.SendData(DataPacket);
        }
    }
}
