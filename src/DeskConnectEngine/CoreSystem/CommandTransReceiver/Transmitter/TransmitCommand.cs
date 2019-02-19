using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkSender;
using System.Configuration;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter
{
   public class TransmitCommand:TransmitBase
    {
        
        public void SendCommand()
        {
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = RemoteSystemName;
            NetworkSend Sender = new NetworkSend(int.Parse(ConfigurationSettings.AppSettings["CommandPort"]));
            Sender.NetworkParameters = NetParams;
            Sender.SendData(DataPacket);
        }
    }
}
