using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Receiver;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.CommandPacket;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.ResultPacket;
using System.Configuration;
using DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter;

namespace DeskConnectEngine.CoreSystem.CommandExecutor.LocalExecutor
{
    public class LocalExecutionManager : ExecutionManager
    {
        public override IResult Execute()
        {
            ExecutionResult ExecResult = Command.ExecuteCommand();
            return ExecResult;
        }

        public void ExecuteRemoteCommand()
        {
            ReceiveCommand GetCmd = new ReceiveCommand();
            PacketElements CmdPacketElement = GetCmd.GetCommandPacket();
            Command = CmdPacketElement.ActualCommand;
            IResult ExecResult = Execute();
            ResultPacketElement ResultElement = new ResultPacketElement();
            ResultElement.ActualResult = ExecResult;
            ResultElement.Header = int.Parse(ConfigurationSettings.AppSettings["ResultHeader"]);
            PackResult PackRes = new PackResult();
            PackRes.ResultPacketElements = ResultElement;
            byte[] ResultPacket = PackRes.ResultPack;
            TransmitResult SendResult = new TransmitResult();
            SendResult.DataPacket = ResultPacket;
            SendResult.RemoteSystemName = GetCmd.SenderIP;
            SendResult.SendResult();


        }
    }
}
