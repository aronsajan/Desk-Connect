using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.ServiceSubsystem;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem;

namespace SystemServiceHandler
{
    public class RetrieveServiceList
    {
        public List<ServiceListResult> RetrieveServices(string RemoteSystem)
        {
            ListAllServices ServiceList = new ListAllServices();
            NetworkParameters NetworkDetails = new NetworkParameters();
            NetworkDetails.RemoteSystemName = RemoteSystem;
            RemoteExecutionManager RemoteExecutor = new RemoteExecutionManager();
            RemoteExecutor.NetParams = NetworkDetails;
            RemoteExecutor.Command = ServiceList;
            IResult Result = RemoteExecutor.Execute();
            List<ServiceListResult> ServiceResult = new List<ServiceListResult>(); 
            if (Result.Result == ExecutionResultType.Passed)
            {
                ServiceResult = Result.ServiceList;
            }

            return ServiceResult;

        }

    }
}
