using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DeskConnectEngine.CoreSystem.ProcessSubsystem
{
    [Serializable]
    public class StopProcess:IExecute
    {
        public ProcessParameters ProcessParameters
        {
            get;
            set;
        }
        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult ExResult = new ExecutionResult(); 
            try
            {
                Stop(ProcessParameters.ProcessName);
                ExResult.Result = ExecutionResultType.Passed;
            }
            catch (Exception ExecutionFailed)
            {
                ExResult.Result = ExecutionResultType.Failed;
                ExResult.FailureException = ExecutionFailed;
            }
            return ExResult;
        }

        private void Stop(string ProcessName)
        {
            Process[] ProcInstance = Process.GetProcessesByName(ProcessName);
            ProcInstance[0].Kill();
        }
    }
}
