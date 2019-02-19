using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DeskConnectEngine.CoreSystem.ProcessSubsystem
{
    [Serializable]
    public class StartProcess:IExecute
    {
        public ProcessParameters ProcessParameters
        {
            get;
            set;
        }

        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult Result = new ExecutionResult(); 
            try
            {
                Start(ProcessParameters.ProcessName);
                Result.Result = ExecutionResultType.Passed;
            }
            catch (Exception ExecutionFailed)
            {
                Result.Result = ExecutionResultType.Failed;
                Result.FailureException = ExecutionFailed;
            }
            return Result;
        }

        private void Start(string ProcessName)
        {
            Process ProcessInstance = new Process();
            ProcessInstance.StartInfo.FileName = ProcessName;
            ProcessInstance.StartInfo.UseShellExecute = true;
            ProcessInstance.Start();
        }

    }
}
