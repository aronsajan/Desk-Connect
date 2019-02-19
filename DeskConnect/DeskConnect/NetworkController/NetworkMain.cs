using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace DeskConnect.NetworkController
{
    class NetworkMain
    {
        public IPAddress GetIP(string SystemName)
        {
            IPAddress[] RemoteSysAddr = Dns.GetHostAddresses(SystemName);
            return RemoteSysAddr[0];
        }
    }
}
