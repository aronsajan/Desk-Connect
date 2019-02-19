using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using InterProcessCommunicator.ProcessCommunicator.Sender;


namespace DeskConnectEngine.CoreSystem.InstantMessenger
{
    [Serializable]
    public class MessageExecutor:IExecute
    {
        public MessageParameters MessageParameters
        {
            get;
            set;
        }
        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult ExecResult = new ExecutionResult();
            try
            {
                string ProcName = ConfigurationSettings.AppSettings["ProcessName"];
                int ChannelNumber = int.Parse(ConfigurationSettings.AppSettings["MessageChannel"]);
                Process[] TargetProcess = Process.GetProcessesByName(ProcName);
                if (TargetProcess.Length > 0)
                {

                    SendingParameters SendParams = new SendingParameters();
                    SendParams.Channel = ChannelNumber;
                    SendParams.MessageEntity = MessageParameters.Message;
                    ExecuteSender ExecuteSend = new ExecuteSender();
                    ExecuteSend.Parameters = SendParams;
                    ExecuteSend.SendData();
                    
                }
                else
                {
                    Process NotifierApp = new Process();
                    NotifierApp.StartInfo.Arguments = MessageParameters.Message;
                    NotifierApp.StartInfo.FileName = Environment.CurrentDirectory + "\\" + ConfigurationSettings.AppSettings["NotifierApp"];
                    NotifierApp.StartInfo.UseShellExecute = false;
                    NotifierApp.Start();
                }

                ExecResult.Result = ExecutionResultType.Passed;
            }
            catch (Exception MessageSendFailed)
            {
                ExecResult.Result = ExecutionResultType.Failed;
                ExecResult.FailureException = MessageSendFailed;
            }

            return ExecResult;

            
        }
    }
}
