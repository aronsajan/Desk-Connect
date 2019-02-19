using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DeskConnectEngine.CoreSystem.ProcessSubsystem;
using DeskConnectEngine.CoreSystem;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace DeskConnectActiveListener.UI
{
    public partial class ActiveListenerPref : Form
    {
        public ActiveListenerPref()
        {
            InitializeComponent();
        }

        private void ActiveListener_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            if (PulseThread != null)
            {
                if (PulseThread.IsAlive)
                {
                    ListenerStatus.Text = "Listening";
                }
                else
                {
                    ListenerStatus.Text = "Not Listening";
                }
            }
            else
            {
                ListenerStatus.Text = "Not Listening";
            }

            StartDeskConnectButton.Enabled = !IsDeskConnectActive;

        }

        private bool IsDeskConnectActive
        {
            get
            {
                if (Process.GetProcessesByName(ConfigurationSettings.AppSettings["DeskConnectApplication"]).Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        public Thread ListenerThread
        {
            get;
            set;
        }
        public Thread MainThread
        {
            get;
            set;
        }

        public Thread PulseThread
        {
            get;
            set;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }



        private void SafeExit()
        {
            if (PulseThread != null)
            {
                if (PulseThread.IsAlive)
                {
                    PulseThread.Abort();
                }
            }
            if (ListenerThread != null)
            {
                if (ListenerThread.IsAlive)
                {
                    ListenerThread.Abort();
                }
            }
            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void StopListButton_Click(object sender, EventArgs e)
        {
            SafeExit();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            string LogFile = Environment.CurrentDirectory + "\\Logs\\" + ConfigurationSettings.AppSettings["ErrorLog"];
            StartProcess LogProcess = new StartProcess();
            ProcessParameters ProcParam = new ProcessParameters();
            ProcParam.ProcessName = LogFile;
            LogProcess.ProcessParameters = ProcParam;
            IResult ExecResult = LogProcess.ExecuteCommand();
            if (ExecResult.Result == ExecutionResultType.Failed)
            {
                MessageBox.Show("Failed to open log file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartDeskConnectButton_Click(object sender, EventArgs e)
        {
            string DeskConnectPath = Environment.CurrentDirectory;
            DeskConnectPath = DeskConnectPath + "\\" + ConfigurationSettings.AppSettings["DeskConnectApplication"]+".exe";
            StartProcess DeskConnectProcess = new StartProcess();
            ProcessParameters ProcParam = new ProcessParameters();
            ProcParam.ProcessName = DeskConnectPath;
            DeskConnectProcess.ProcessParameters = ProcParam;
            IResult ExecResult = DeskConnectProcess.ExecuteCommand();
            if (ExecResult.Result == ExecutionResultType.Failed)
            {
                MessageBox.Show("Failed to start Desk Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshStatus();

        }


       
    }
}
