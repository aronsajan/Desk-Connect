using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DeskConnectEngine.CoreSystem.BatchSubsystem
{
    [Serializable]
    public class ExecuteBatchFile : IExecute
    {
        #region Remote Batch Execution Parameters
        public BatchExecuteParameters BatchOperationParameters
        {
            get;
            set;
        }
        #endregion

        #region Remote Batch File Execution portion
        public ExecutionResult ExecuteCommand()
        {
            ExecutionResult ExecResult = new ExecutionResult();

            try
            {
                RemoteBatchFullname = string.Format("{0}\\{1}", BatchOperationParameters.RemoteExecuteLocation, BatchOperationParameters.BatchFile.BatchFilename);
                SaveBatchFileContents();
                ExecuteBatch();
                ExecResult.Result = ExecutionResultType.Passed;

            }
            catch (Exception ExecutionFailed)
            {
                ExecResult.Result = ExecutionResultType.Failed;
                ExecResult.FailureException = ExecutionFailed;
            }

            return ExecResult;
        }

        private string RemoteBatchFullname
        {
            get;
            set;
        }
        public ExecuteBatchFile()
        {

        }

        private void ExecuteBatch()
        {
            Process BatchProcess = new Process();
            BatchProcess.StartInfo.FileName = RemoteBatchFullname;
            BatchProcess.StartInfo.WorkingDirectory = BatchOperationParameters.RemoteExecuteLocation;
            if (BatchOperationParameters.HasCommandLineArguments)
            {
                BatchProcess.StartInfo.UseShellExecute = false;
                BatchProcess.StartInfo.Arguments = BatchOperationParameters.CommandLineArguments;
            }
            else
            {
                BatchProcess.StartInfo.UseShellExecute = true;
            }
            if (BatchOperationParameters.ShowBatchExecution)
            {
                BatchProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            }
            else
            {
                BatchProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }

            BatchProcess.Start();
        }

        private void SaveBatchFileContents()
        {


            StreamWriter BatchFileWriter = new StreamWriter(RemoteBatchFullname);
            BatchFileWriter.WriteLine(BatchOperationParameters.BatchFile.BatchFileContents);
            BatchFileWriter.Close();
        }
        #endregion
    }
}
