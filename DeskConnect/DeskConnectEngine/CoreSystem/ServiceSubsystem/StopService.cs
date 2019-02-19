using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace DeskConnectEngine.CoreSystem.ServiceSubsystem
{
    [Serializable]
    public class StopService : IExecute
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
                Stop(ServiceParameters.ServiceName);
                ExecResult.Result = ExecutionResultType.Passed;
            }
            catch (Exception ExecutionFailed)
            {
                ExecResult.Result = ExecutionResultType.Failed;
                ExecResult.FailureException = ExecutionFailed;
            }

            return ExecResult;
        }

        private void Stop(string ServiceName)
        {
            ServiceController ServiceInstance = new ServiceController();
            ServiceInstance.ServiceName = ServiceName;
            if ((ServiceInstance.Status == ServiceControllerStatus.Running) || (ServiceInstance.Status == ServiceControllerStatus.StartPending))
            {
                ServiceInstance.Stop();
            }
            else
            {
                throw (new ApplicationException(ServiceName + " is already stopped"));
            }
        }
    }
}
