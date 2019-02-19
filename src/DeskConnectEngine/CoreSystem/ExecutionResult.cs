using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.ServiceSubsystem;

namespace DeskConnectEngine.CoreSystem
{
    [Serializable]
    public class ExecutionResult:IResult
    {
        public ExecutionResultType Result
        {
            get;
            set;
        }

        public Exception FailureException
        {
            get;
            set;
        }

        public List<ServiceListResult> ServiceList
        {
            get;
            set;
        }

        public List<string> ActiveProcesses
        {
            get;
            set;
        }


    }
}
