using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProcessManagerUI.NewProcess;
using DeskConnectEngine.CoreSystem.CommandExecutor.RemoteExecutor;
using DeskConnectEngine.CoreSystem.NetworkSubsystem;
using DeskConnectEngine.CoreSystem.ProcessSubsystem;
using DeskConnectEngine.CoreSystem;
using DeskConnectEngine.CoreSystem.DeskConnectSubsystem.SystemListDataRepository;

namespace ProcessManagerUI
{
    public partial class ProcessManagerControl : UserControl
    {
        public ProcessManagerControl()
        {
            InitializeComponent();
        }

        private void ProcessManagerControl_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MachineNameCombo.SelectedIndex >= 0)
            {
                NewProcessParameters NewProc = new NewProcessParameters();
                NewProc.RemoteMachineName = MachineName;
                NewProc.ParentUserControl = this;
                NewProc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a machine and then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoLabel_Click(object sender, EventArgs e)
        {
            if (MachineNameCombo.SelectedIndex >= 0)
            {
                try
                {
                    RetrieveAllProcesses();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Communication with the remote system failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a machine and then continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InitControls()
        {
            StopProcessButton.Enabled = false;
            ConfigurationManager MachineRepository = new ConfigurationManager();
            SystemRepositoryRoot Repository = MachineRepository.ReadRepository();
            foreach (SystemAttributes Machine in Repository.SystemRepository)
            {
                MachineNameCombo.Items.Add(Machine.SystemName);
            }
        }



        private string MachineName
        {
            get
            {
                return MachineNameCombo.SelectedItem.ToString();
            }
        }

        public void RetrieveAllProcesses()
        {
            RemoteExecutionManager RemoteProcessList = new RemoteExecutionManager();
            NetworkParameters NetParams = new NetworkParameters();
            NetParams.RemoteSystemName = MachineName;
            ListAllProcesses AllProcList = new ListAllProcesses();
            RemoteProcessList.Command = AllProcList;
            RemoteProcessList.NetParams = NetParams;
            IResult RemoteExecResult = RemoteProcessList.Execute();
            if (RemoteExecResult.Result == ExecutionResultType.Passed)
            {
                PopulateProcessListView(RemoteExecResult as ExecutionResult);
            }
            else
            {
                MessageBox.Show("Retrieving remote process list, from machine " + MachineName + ", failed due to the following reason : " + RemoteExecResult.FailureException.Message, "Desk Connect - Process Retrieval Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulateProcessListView(ExecutionResult Result)
        {
            ProcessListView.Items.Clear();
            List<string> processes = Result.ActiveProcesses;
            foreach (string process in processes)
            {
                ListViewItem ProcItem = new ListViewItem(process);
                ProcessListView.Items.Add(ProcItem);
                GC.Collect();
            }
        }

        private void ProcessListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems.Count == 1)
            {
                SelectedProcess = ProcessListView.SelectedItems[0].Text;
                StopProcessButton.Enabled = true;
            }
            else
            {
                StopProcessButton.Enabled = false;
            }
        }

        private string SelectedProcess
        {
            get;
            set;
        }

        private void StopProcessButton_Click(object sender, EventArgs e)
        {
            IResult ExecResult = ExecuteStopCommand();
            if (ExecResult.Result == ExecutionResultType.Passed)
            {
                MessageBox.Show("Process " + SelectedProcess + " has been successfully stopped on the remote machine, " + MachineName, "Desk Connect - Process Stop Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RetrieveAllProcesses();
            }
            else
            {
                MessageBox.Show("Failed to stop process " + SelectedProcess + " on remote machine, " + MachineName + ", due to the following reason : " + ExecResult.FailureException.Message, "Desk Connect - Process Stop Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private IResult ExecuteStopCommand()
        {
            IResult ExecuteResult = new ExecutionResult();
            if (SelectedProcess.Length > 0)
            {
                StopProcess CmdStopProc = new StopProcess();
                ProcessParameters ProcParam = new ProcessParameters();
                NetworkParameters NetParam = new NetworkParameters();
                NetParam.RemoteSystemName = MachineName;
                ProcParam.ProcessName = SelectedProcess;
                CmdStopProc.ProcessParameters = ProcParam;
                RemoteExecutionManager ProcessStop = new RemoteExecutionManager();
                ProcessStop.Command = CmdStopProc;
                ProcessStop.NetParams = NetParam;
                ExecuteResult = ProcessStop.Execute();

            }
            return ExecuteResult;
        }

    }
}
