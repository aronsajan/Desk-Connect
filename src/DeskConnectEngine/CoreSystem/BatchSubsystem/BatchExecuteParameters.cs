using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskConnectEngine.CoreSystem.BatchSubsystem
{
    [Serializable]
    public class BatchExecuteParameters
    {
        string RemoteExecLoc;
        public BatchExecuteParameters()
        {
            RemoteExecLoc = "";
        }

        public bool ShowBatchExecution
        {
            get;
            set;
        }

        public bool HasCommandLineArguments
        {
            get;
            set;
        }

        public string CommandLineArguments
        {
            get;
            set;
        }

        public string RemoteExecuteLocation
        {
            get
            {
                return RemoteExecLoc;
            }
            set
            {
                RemoteExecLoc = value;
            }
        }
        public BatchFile BatchFile
        {
            get;
            set;
        }
    }
}
