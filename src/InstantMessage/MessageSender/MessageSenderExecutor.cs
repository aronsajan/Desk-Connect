using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.InstantMessenger;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;

namespace InstantMessage.MessageSender
{
    class MessageSenderExecutor
    {
        public MessageExecutor PrepareMessage(string MessageText)
        {
            MessageParameters MsgParam = new MessageParameters();
            string LocalMachine = Environment.MachineName;
            MsgParam.Message = LocalMachine + " : " + MessageText;
            MessageExecutor MessageExecutor = new MessageExecutor();
            MessageExecutor.MessageParameters = MsgParam;
            return MessageExecutor;
        }

        public IResult SendMessage(MessageExecutor Msg,string TargetSystemName)
        {
            RemoteExecutionManager RemoteExec = new RemoteExecutionManager();
            RemoteExec.Command = Msg;
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = TargetSystemName;
            RemoteExec.NetParams = NetParams;
            IResult ExecutionResult = RemoteExec.Execute();
            return ExecutionResult;

        }
    }
}
