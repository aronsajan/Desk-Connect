using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace DeskConnectEngine.CoreSystem.ServiceSubsystem
{
    [Serializable]
    public class StartService : IExecute
    {
        public ServiceParameters ServiceParameters
        {
            get;
            set;
        }

        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult ExecResult = new ExecutionResult(); 
            try
            {
                Start(ServiceParameters.ServiceName);
                ExecResult.Result = ExecutionResultType.Passed;
            }
            catch (Exception ExecutionFailed)
            {
                ExecResult.Result = ExecutionResultType.Failed;
                ExecResult.FailureException = ExecutionFailed; 
            }

            return ExecResult;
        }

        private void Start(string ServiceName)
        {
            ServiceController ServiceInstance = new ServiceController();
            ServiceInstance.ServiceName = ServiceName;
            if ((ServiceInstance.Status != ServiceControllerStatus.Running) && (ServiceInstance.Status != ServiceControllerStatus.StartPending))
            {
                ServiceInstance.Start();
            }
            else
            {
                throw (new ApplicationException(ServiceName + " is already running"));
            }
        }
    }
}
