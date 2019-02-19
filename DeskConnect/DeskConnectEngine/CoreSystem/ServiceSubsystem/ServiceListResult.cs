using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace DeskConnectEngine.CoreSystem.ServiceSubsystem
{
    [Serializable]
    public class ServiceListResult
    {
        public string ServiceName
        {
            get;
            set;
        }
        public ServiceControllerStatus ServiceStatus
        {
            get;
            set;
        }
    }
}
