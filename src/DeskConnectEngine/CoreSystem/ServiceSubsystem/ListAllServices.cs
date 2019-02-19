using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace DeskConnectEngine.CoreSystem.ServiceSubsystem
{
    [Serializable]
   public class ListAllServices:IExecute
    {

        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult execResult = new ExecutionResult();
            try
            {
                
                execResult.ServiceList = ListServices();
                execResult.Result = ExecutionResultType.Passed;
            }
            catch (Exception ex)
            {
                execResult.Result = ExecutionResultType.Failed;
                execResult.FailureException = ex;
            }

            return execResult;
        }

        private List<ServiceListResult> ListServices()
        {
            ServiceController[] LocalServiceList = ServiceController.GetServices();
            List<ServiceListResult> ServiceList = new List<ServiceListResult>(); 
            foreach (ServiceController serviceInstance in LocalServiceList)
            {
                ServiceListResult ServiceListInstance = new ServiceListResult();
                GC.Collect();
                ServiceListInstance.ServiceName = serviceInstance.ServiceName;
                ServiceListInstance.ServiceStatus = serviceInstance.Status;
                ServiceList.Add(ServiceListInstance);
            }

            return ServiceList;

        }
    }
}
