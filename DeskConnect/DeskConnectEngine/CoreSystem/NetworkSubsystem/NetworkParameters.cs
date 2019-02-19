using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace DeskConnectEngine.CoreSystem.NetworkSubsystem
{
   public class NetworkParameters
    {
        public string RemoteSystemName
        {
            get;
            set;
        }
        public IPAddress RemoteSystemIP
        {
            get
            {
                IPAddress[] IPList = Dns.GetHostByName(RemoteSystemName).AddressList;
                return IPList[0];
            }
        }
    }
}
