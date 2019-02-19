using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeskConnectEngine.CoreSystem.CommandExecutor.LocalExecutor;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using DeskConnectActiveListener.Logger;

namespace DeskConnectActiveListener
{
    class ActiveListener
    {
       public Thread ExecutionThread;
       

        private void Execute()
        {
            try
            {
                LocalExecutionManager ExecManager = new LocalExecutionManager();
                ExecManager.ExecuteRemoteCommand();
            }
            catch (Exception Ex)
            {
                string LogFile = Environment.CurrentDirectory + "\\Logs\\" + ConfigurationSettings.AppSettings["ErrorLog"];
                ErrorLogger.Log(LogFile, Ex);

            }

        }
        
        public void Start()
        {
            ListenerPulse();
        }

        private void ListenerPulse()
        {
            while (true)
            {
                if (ExecutionThread != null)
                {
                    if (!ExecutionThread.IsAlive)
                    {
                        RunThread();
                        GC.Collect();
                    }
                }
                else
                {
                    RunThread();
                    Thread.Sleep(1000);
                }
                Thread.Sleep(500);
                
            }

        }

        private void RunThread()
        {
            ExecutionThread = new Thread(Execute);
            ExecutionThread.Priority = ThreadPriority.Highest;
            ExecutionThread.Start();
        }


    }
}
