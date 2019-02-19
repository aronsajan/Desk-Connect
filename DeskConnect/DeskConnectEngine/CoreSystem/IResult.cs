using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.ServiceSubsystem;

namespace DeskConnectEngine.CoreSystem
{
    public interface IResult
    {
        ExecutionResultType Result
        {
            get;
            set;
        }
        Exception FailureException
        {
            get;
            set;
        }

        List<ServiceListResult> ServiceList
        {
            get;
            set;
        }
    }
}
