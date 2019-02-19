using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskConnectEngine.CoreSystem.CommandTransReceiver.Transmitter
{
   public abstract class TransmitBase
    {
        public byte[] DataPacket
        {
            get;
            set;
        }
        public string RemoteSystemName
        {
            get;
            set;
        }
    }
}
