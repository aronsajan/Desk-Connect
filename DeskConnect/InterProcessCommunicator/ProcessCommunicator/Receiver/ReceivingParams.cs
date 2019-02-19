using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterProcessCommunicator.ProcessCommunicator.Receiver
{
    public class ReceivingParams
    {
        public ReceivingParams()
        {
            DataReceived = false; 
        }
        public int Channel
        {
            get;
            set;
        }

        public bool DataReceived
        {
            get;
            set;
        }
    }
}
