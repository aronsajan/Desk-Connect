using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskConnectEngine.CoreSystem.CommandExecutor
{
    public abstract class ExecutionManager
    {
        public IExecute Command
        {
            get;
            set;
        }
        public abstract IResult Execute();
    }
}
