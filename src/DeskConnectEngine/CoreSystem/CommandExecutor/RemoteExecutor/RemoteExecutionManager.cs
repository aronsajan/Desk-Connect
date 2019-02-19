using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket;
using System.Configuration;
using DeskConnectEngine.CoreSystem.NetworkSubsystem.NetworkSender;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Receiver;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket;

namespace DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor
{
    public class RemoteExecutionManager : ExecutionManager
    {
        public NetworkParameters NetParams
        {
            get;
            set;
        }
        public override IResult Execute()
        {
            #region Code for sending command to remote system
            PacketElements CommandPacketElems = new PacketElements();
            CommandPacketElems.ActualCommand = Command;
            long HeaderValue = long.Parse(ConfigurationSettings.AppSettings["CommandHeader"]);
            CommandPacketElems.Header = HeaderValue;
            PackCommand CommandPckt = new PackCommand();
            CommandPckt.PacketElements = CommandPacketElems;
            TransmitCommand SendCmd = new TransmitCommand();
            SendCmd.DataPacket = CommandPckt.CommandPack;
            SendCmd.RemoteSystemName = NetParams.RemoteSystemName;
            SendCmd.SendCommand(); 
            #endregion

            #region Code for receiving result from remote system
            ReceiveResult ReceiveData = new ReceiveResult();
            ResultPacketElement ResultElements = ReceiveData.GetResultPacket();
            IResult Result=new ExecutionResult();
            if(ResultElements.Header==int.Parse(ConfigurationSettings.AppSettings["ResultHeader"]))
            {
              Result=ResultElements.ActualResult;
            }
            else
            {
                throw(new ApplicationException("Corrupted Result"));
            }
            #endregion
            return Result;
        }
    }
}
