using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DeskConnectEngine.CoreSystem.ProcessSubsystem
{
    [Serializable]
   public class ListAllProcesses:IExecute
    {
        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult ExecResult = new ExecutionResult();
            try
            {
                List<string> ProcessList = ActiveProcesses;
                ExecResult.Result = ExecutionResultType.Passed;
                ExecResult.ActiveProcesses = ProcessList;

            }
            catch(Exception ex)
            {
                ExecResult.Result = ExecutionResultType.Failed;
                ExecResult.FailureException = ex;
            }
            return ExecResult;
        }
        private List<string> ActiveProcesses
        {
            get
            {
                List<string> ProcList = new List<string>();
                Process[] Processes = Process.GetProcesses();
              
                foreach (Process Proc in Processes)
                {
                    ProcList.Add(Proc.ProcessName);
                }
                return ProcList;
            }
        }
    }
}
